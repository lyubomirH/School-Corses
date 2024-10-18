using Fractions;
using System.Globalization;
using System.Reflection.Metadata;

namespace Calculation_with_Fractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputArr = Console.ReadLine().Split(" ").ToArray();

            int[] firstFractionInput = inputArr[0].Split("/").Select(int.Parse).ToArray();
            int[] secondFractionInput = inputArr[2].Split("/").Select(int.Parse).ToArray();
            string sing = inputArr[1];

            Fraction fractionOne= new Fraction(firstFractionInput[0], firstFractionInput[1]);
            Fraction fractionTwo = new Fraction(secondFractionInput[0], secondFractionInput[1]);

            if (sing == "+")
            {
                Console.WriteLine($"{fractionOne} {sing} {fractionTwo} = {fractionOne + fractionTwo}");
            }
            else
            {
                Console.WriteLine($"{fractionOne} {sing} {fractionTwo} = {fractionOne - fractionTwo}");
            }
        }
    }
}
