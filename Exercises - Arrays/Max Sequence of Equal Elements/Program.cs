using System.Runtime.Serialization.Formatters;

namespace Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int point = 1;
            int moustNum = 0;
            int theNum = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    point++;
                }
                else
                {
                    point = 1;
                }
                if (point > moustNum)
                {
                    moustNum = point;
                    theNum = arr[i];
                }
            }
            for (int j = 1; j <= moustNum; j++)
            {
                Console.Write($"{theNum} ");
            }
        }
    }
}