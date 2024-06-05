using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decimal_transform
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number (or 'exit' to quit): ");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "exit")
                    break;
                ConvertNumber(userInput);
            }
        }

        static void ConvertNumber(string numberStr)
        {
            if (numberStr.StartsWith("0x"))
            {

                string hexValue = numberStr.Substring(2);
                int decimalValue = Convert.ToInt32(hexValue, 16);
                string binaryValue = Convert.ToString(decimalValue, 2);
                Console.WriteLine($"Decimal: {decimalValue}");
                Console.WriteLine($"Hexadecimal: {numberStr}");
                Console.WriteLine($"Binary: 0B{binaryValue}");
            }
            else if (numberStr.StartsWith("0B"))
            {

                string binaryValue = numberStr.Substring(2);
                int decimalValue = Convert.ToInt32(binaryValue, 2);
                string hexValue = decimalValue.ToString("X");
                Console.WriteLine($"Decimal: {decimalValue}");
                Console.WriteLine($"Hexadecimal: 0x{hexValue}");
                Console.WriteLine($"Binary: {numberStr}");
            }
            else
            {

                int decimalValue = int.Parse(numberStr);
                string hexValue = decimalValue.ToString("X");
                string binaryValue = Convert.ToString(decimalValue, 2);
                Console.WriteLine($"Decimal: {decimalValue}");
                Console.WriteLine($"Hexadecimal: 0x{hexValue}");
                Console.WriteLine($"Binary: 0B{binaryValue}");
            }
        }
    }
}