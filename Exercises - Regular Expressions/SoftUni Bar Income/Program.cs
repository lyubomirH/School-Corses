using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"%(?<name>[A-Z][a-z]+)%<(?<tipe>[\w]+)>\|(?<quantity>[\d])\|(?<cost>[\d+(.)?\d+?]+)\$");
            string input = "";
            List<string> outputs = new List<string>();
            double totalCost = 0;
            while(input.ToLower() != "end of shift")
            {
                input = Console.ReadLine();
                if (regex.IsMatch(input) == true)
                {
                    StringBuilder line = new StringBuilder();

                    Match match = regex.Match(input);

                    string tipe = match.Groups["tipe"].Value;
                    string name = match.Groups["name"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    double price = double.Parse(match.Groups["cost"].Value);

                    double priceCost = price * quantity;
                    line.Append($"{name}: {tipe} - {priceCost:f2}");
                    string lineForOutput = line.ToString();
                    outputs.Add(lineForOutput);

                    totalCost += priceCost;
                }
                
            }
            foreach(string output in outputs) 
            {
                Console.WriteLine(output);
            }
            Console.WriteLine($"Total income: {totalCost:f2}");
        }
    }
}