﻿namespace Sum_Adjacent_Equal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToList();

            Console.WriteLine( Sum(nums));
        }
        static string Sum(List<double> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (i == nums.Count - 1)
                {
                    break;
                }
                if (nums[i] == nums[i + 1])
                {
                    nums[i] += nums[i + 1];
                    nums.RemoveAt(i + 1);
                    i += -1;
                }

            }
            return string.Join(" ", nums);
        }
    }
}