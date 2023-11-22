using System.Reflection;

namespace Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            double timeOne = 0;
            double timeTwo = 0;
            for(int i = 0; i < nums.Count / 2; ++i)
            {
                timeOne += nums[i];
                if (nums[i] == 0)
                {
                    timeOne *= 0.8; 
                }
            }
            for (int i = nums.Count -1; i > nums.Count / 2; --i)
            {
                timeTwo += nums[i];
                if (nums[i] == 0)
                {
                    timeTwo *= 0.8;
                }
            }
            winner(timeOne, timeTwo);
            
        }
        static void winner(double timeOne, double timeTwo)
        {
            if(timeOne < timeTwo)
            {
                Console.WriteLine($"The winner is left with total time: {timeOne:f2}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {timeTwo:f2}");
            }
        }
    }
}