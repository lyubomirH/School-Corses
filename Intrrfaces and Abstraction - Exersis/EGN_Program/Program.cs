using EGN_Program;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EGN_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            IEGNValidator validator = new EGNValidator();
            IEGNDataProvider dataProvider = (IEGNDataProvider)validator;
            List<string> egnList = new List<string>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== СИСТЕМА ЗА УПРАВЛЕНИЕ НА ЕГН-та ===");
                Console.WriteLine("1. Добави ново ЕГН");
                Console.WriteLine("2. Покажи всички ЕГН-та");
                Console.WriteLine("3. Генерирай ново ЕГН");
                Console.WriteLine("4. Изход");
                Console.WriteLine("=== === === === === === === === === ===");
                Console.Write("Избери опция: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddEGN(validator, egnList);
                        break;
                    case "2":
                        ShowAllEGNs(validator, dataProvider, egnList);
                        break;
                    case "3":
                        GenerateEGN(validator, egnList);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Невалиден избор!");
                        break;
                }

                Console.WriteLine("\nНатисни произволен клавиш...");
                Console.ReadKey();
            }
        }

        static void AddEGN(IEGNValidator validator, List<string> egnList)
        {
            Console.Write("Въведи ЕГН: ");
            string egn = Console.ReadLine();

            if (validator.Validate(egn))
            {
                egnList.Add(egn);
                Console.WriteLine("ЕГН добавено успешно!");
            }
            else
            {
                Console.WriteLine("Невалидно ЕГН!");
            }
        }

        static void ShowAllEGNs(IEGNValidator validator, IEGNDataProvider dataProvider, List<string> egnList)
        {
            if (egnList.Count == 0)
            {
                Console.WriteLine("Няма записани ЕГН-та.");
                return;
            }

            foreach (string egn in egnList)
            {
                DateTime birthDate;
                if (TryParseEGNDate(egn, out birthDate))
                {
                    int genderDigit = egn[8] - '0';
                    int regionCode = int.Parse(egn.Substring(6, 3));

                    Console.WriteLine($"\nЕГН: {egn}");
                    Console.WriteLine($"Дата на раждане: {birthDate:dd.MM.yyyy}");
                    Console.WriteLine($"Пол: {(genderDigit % 2 == 1 ? "Жена" : "Мъж")}");
                    Console.WriteLine($"Регион: {dataProvider.GetRegionName(regionCode)}");
                    Console.WriteLine($"Валидност: {(validator.Validate(egn) ? "Валидно" : "Невалидно")}");
                    Console.WriteLine(new string('-', 40));
                }
            }
        }

        static bool TryParseEGNDate(string egn, out DateTime birthDate)
        {
            birthDate = DateTime.MinValue;
            try
            {
                int year = int.Parse(egn.Substring(0, 2));
                int month = int.Parse(egn.Substring(2, 2));
                int day = int.Parse(egn.Substring(4, 2));

                if (month >= 20 && month <= 32)
                {
                    year += 1800;
                    month -= 20;
                }
                else if (month >= 40 && month <= 52)
                {
                    year += 2000;
                    month -= 40;
                }
                else
                {
                    year += 1900;
                }

                birthDate = new DateTime(year, month, day);
                return true;
            }
            catch
            {
                return false;
            }
        }

        static void GenerateEGN(IEGNValidator validator, List<string> egnList)
        {
            try
            {
                Console.Write("Дата на раждане (дд.мм.гггг): ");
                DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);

                Console.Write("Град: ");
                string city = Console.ReadLine();

                Console.Write("Пол (м/ж): ");
                bool isMale = Console.ReadLine().ToLower() == "м";

                string[] generatedEGNs = validator.Generate(birthDate, city, isMale);

                if (generatedEGNs.Length > 0)
                {
                    Console.WriteLine("\nГенерирани ЕГН-та:");
                    for (int i = 0; i < generatedEGNs.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {generatedEGNs[i]}");
                    }

                    Console.Write("\nЗапази ЕГН (номер или 0 за отказ): ");
                    if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= generatedEGNs.Length)
                    {
                        egnList.Add(generatedEGNs[index - 1]);
                        Console.WriteLine("ЕГН запазено успешно!");
                    }
                }
                else
                {
                    Console.WriteLine("Не са генерирани валидни ЕГН-та.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Грешка: {ex.Message}");
            }
        }

        static string GetRegionName(int regionCode)
        {
            foreach (var region in EGNValidator.REGIONAL_CODES)
            {
                if (regionCode >= region.Value[0] && regionCode <= region.Value[1])
                {
                    return region.Key;
                }
            }
            return "Неизвестен регион";
        }
    }
}