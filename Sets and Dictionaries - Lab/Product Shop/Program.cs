using System.Security.Cryptography.X509Certificates;

namespace Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                    .Split(", ");
            var suprmarket = new SortedDictionary<string, Dictionary<string, double>>();
            while (input[0] != "Revision")
            {
                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (suprmarket.ContainsKey(shop))
                {

                }
                else 
                { 
                    suprmarket.Add(shop, new Dictionary<string, double>());
                    suprmarket[shop].Add(product, price);
                }
                input = Console.ReadLine()
                    .Split(", ");
            }
            foreach(var kvp in suprmarket)
            {
                Console.WriteLine($"{kvp.Key}->");
                foreach(var item in kvp.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
                
            }
        }
    }
}