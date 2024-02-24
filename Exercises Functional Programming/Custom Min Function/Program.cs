using System.Collections.Generic;
using System;

namespace Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> func = GetMin;
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int MinNum = func(nums);
            Console.WriteLine(MinNum);
        }
        static int GetMin(int[] arr)
        {
            int min = int.MaxValue;
            foreach (int i in arr)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }
    }
}