using EGN_Program;
using System;
using System.Collections.Generic;

namespace EGN_Program
{
    public class EGNValidator : IEGNValidator, IEGNDataProvider
    {
        private static readonly int[] CHECKSUM_WEIGHTS = { 2, 4, 8, 5, 10, 9, 7, 3, 6 };

        public static readonly Dictionary<string, int[]> REGIONAL_CODES = new Dictionary<string, int[]> //REGIONAL_CODES
        {
            {"Благоевград", new int[] {0, 43}},
            {"Бургас", new int[] {44, 93}},
            {"Варна", new int[] {94, 139}},
            {"Велико Търново", new int[] {140, 169}},
            {"Видин", new int[] {170, 183}},
            {"Враца", new int[] {184, 217}},
            {"Габрово", new int[] {218, 233}},
            {"Кърджали", new int[] {234, 281}},
            {"Кюстендил", new int[] {282, 301}},
            {"Ловеч", new int[] {302, 319}},
            {"Монтана", new int[] {320, 341}},
            {"Пазарджик", new int[] {342, 377}},
            {"Перник", new int[] {378, 395}},
            {"Плевен", new int[] {396, 435}},
            {"Пловдив", new int[] {436, 501}},
            {"Разград", new int[] {502, 527}},
            {"Русе", new int[] {528, 555}},
            {"Силистра", new int[] {556, 575}},
            {"Сливен", new int[] {576, 601}},
            {"Смолян", new int[] {602, 623}},
            {"София - град", new int[] {624, 721}},
            {"София - окръг", new int[] {722, 751}},
            {"Стара Загора", new int[] {752, 789}},
            {"Добрич (Толбухин)", new int[] {790, 821}},
            {"Търговище", new int[] {822, 843}},
            {"Хасково", new int[] {844, 871}},
            {"Шумен", new int[] {872, 903}},
            {"Ямбол", new int[] {904, 925}},
            {"Друг/Неизвестен", new int[] {926, 999}}
        };

        public bool Validate(string egn)
        {
            if (string.IsNullOrWhiteSpace(egn) || egn.Length != 10 || !egn.All(char.IsDigit)) // All чрез ЦхатГПТ
            {
                return false;
            }
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

                DateTime birthDate = new DateTime(year, month, day);
                if (birthDate > DateTime.Now)
                {
                    return false;
                }

                int checksum = CalculateChecksum(egn);
                int lastDigit = egn[9] - '0';

                return checksum == lastDigit;
            }
            catch
            {
                return false;
            }
        }

        private int CalculateChecksum(string partialEGN)
        {
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                sum += (partialEGN[i] - '0') * CHECKSUM_WEIGHTS[i];
            }
            int checksum = sum % 11;
            return checksum < 10 ? checksum : 0;
        }

        public string[] Generate(DateTime birthDate, string city, bool isMale)
        {
            if (!REGIONAL_CODES.ContainsKey(city))
            {
                return Array.Empty<string>();
            }

            int[] regionRange = REGIONAL_CODES[city];
            var validEGNs = new List<string>();
            string datePart = FormatDateForEGN(birthDate);

            for (int serial = regionRange[0]; serial <= regionRange[1]; serial++)
            {
                string serialPart = serial.ToString("D2");
                for (int genderDigit = isMale ? 1 : 0; genderDigit <= 9; genderDigit += 2)
                {

                    string partialEGN = datePart + serialPart.Substring(0, 2) + genderDigit;

                    int checksum = CalculateChecksum(partialEGN);
                    string fullEGN = partialEGN + checksum;

                    if (Validate(fullEGN))
                        validEGNs.Add(fullEGN);
                }
            }
            return validEGNs.ToArray();
        }

        private string FormatDateForEGN(DateTime date)
        {
            int year = date.Year % 100;
            int month = date.Month;
            int day = date.Day;

            if (date.Year >= 1800 && date.Year <= 1899)
            {
                month += 20;
            }
            else if (date.Year >= 2000 && date.Year <= 2099) 
            { 
                month += 40; 
            }

            return $"{year:D2}{month:D2}{day:D2}";
        }
        public string GetRegionName(int regionCode)
        {
            foreach (var region in REGIONAL_CODES)
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