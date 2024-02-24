using System.Globalization;

namespace Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

                string input = Console.ReadLine();

            Func<int, bool> check;
            if (input == "even")
                check = n => n % 2 == 0;
            if (input == "odd")
                check = n => n % 2 == 0;

            List<int> list = Enumerable.Range(nums[0], nums[1] - nums[0].Where(check).ToList();

            Console.WriteLine(string.Join(", ", list);
        }
    }
}