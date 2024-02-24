using System;
namespace Custom_Comparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();

            Func<int, int, int> customComparator = (a, b) => (a % 2 == 0 && b % 2 != 0) ? -1 :
                                                             (a % 2 != 0 && b % 2 == 0) ? 1 : a - b;
            Array.Sort(numbers, (x, y) => customComparator(x, y));
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}