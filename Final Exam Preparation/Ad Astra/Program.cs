using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([|#])(?<item>[A-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>[0-9]{1,4}|10000)\1";
            string text = Console.ReadLine();
            int caloroes = 0;

            foreach(Match match in Regex.Matches(text, pattern))
            {
                caloroes += int.Parse(match.Groups["calories"].Value);
            }
            int totalDays = caloroes / 2000;
            Console.WriteLine($"You have food to last you for: {totalDays} days!");

            foreach (Match match in Regex.Matches(text, pattern))
            {
                Console.WriteLine($"Item: {match.Groups["item"].Value}, Best before: {match.Groups["date"].Value}, Nutrition: {match.Groups["calories"].Value}");
            }
        }
    }
}
