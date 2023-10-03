using System.Numerics;

namespace Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           decimal n = decimal.Parse(Console.ReadLine());
           decimal summed = 0;

            for (int i = 0; i < n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                summed += number;
            }
            Console.WriteLine(value:$"{summed}");
        }
    }
}