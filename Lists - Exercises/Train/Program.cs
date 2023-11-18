using System.Threading.Channels;

namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> train = GetInList();

            int campasete = int.Parse(Console.ReadLine());
            string[] command = GetStringArray();
            while (command[0]?.ToLower() != "end")
            {
                switch (command[0]?.ToLower())
                {
                    case "add":
                        train.Add(int.Parse(command[1]));
                        break;
                    default:
                        AddNumbersToListElement(train, campasete, command[0]);
                        break;
                }
                command = GetStringArray();
            }
            Console.WriteLine(string.Join(" ", train));
        }

        static List<int> GetInList()
        {
            return Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
        }
        static string[] GetStringArray()
        {
            return Console.ReadLine()
                .Split(" ")
                .ToArray();
        }
        static List<int> AddNumbersToListElement (List<int> list, int campasety, string num)
        {
            int convertedNumber= int.Parse(num);
            for (int i = 0; i< list.Count; i++)
            {
                if (list[i] + convertedNumber <= campasety)
                {
                    list[i] += convertedNumber;
                    break;
                }
            }
            return list;
        }

    }
}