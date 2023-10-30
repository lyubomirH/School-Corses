﻿namespace Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            if (command == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                HigherThenTwo(first, second);
            }
            else if (command == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                HigherThenTwo(first, second);
            }
            else if (command == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                HigherThenTwo(first, second);
            }
        }
        static int HigherThenTwo(int first, int second)
        {

            int result = 0;
            if (first > second)
            {
                result = first;
            }
            else
            {
                result = second;
            }
            Console.WriteLine(result);
            return result;
        }
        static char HigherThenTwo(char first, char second)
        {

            int result;
            if (first > second)
            {
                result = first;
            }
            else
            {
                result = second;
            }
            Console.WriteLine((char)result);
            return (char)result;

        }
        static string HigherThenTwo(string first, string second)
        {
            string result = string.Empty;
            int firstSum = 0;
            int secondSum = 0;
            foreach (char c in first)
            {
                firstSum += c;
            }
            foreach (char c in second)
            {
                secondSum += c;
            }
            if (firstSum > secondSum)
            {
                result = first;
            }
            else
            {
                result = second;
            }
            Console.WriteLine(result);
            return result;
        }
    }
}