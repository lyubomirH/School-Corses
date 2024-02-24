using System;
namespace Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .Reverse()
                                   .ToArray();

            int divisor = int.Parse(Console.ReadLine());
            Func<int, bool> predicate = x => x % divisor != 0;
            Console.WriteLine(String.Join(" ", numbers.Where(predicate)));
        }
    }
}