using System.Security.Cryptography.X509Certificates;

namespace Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materialQ = new Dictionary<string, int>();
            materialQ.Add("shards", 0);
            materialQ.Add("fragments", 0);
            materialQ.Add("motes", 0);

            SortedDictionary<string, int> junks = new SortedDictionary<string, int>();
            
            bool LegendaryItem = false;

            while (LegendaryItem == false)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .Select(x => x.ToLower())
                    .ToArray();
                for(int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1];
                    if (materialQ.ContainsKey(material))
                    {
                        materialQ[material] += quantity;
                    }
                    else if (junks.ContainsKey(material))
                    {
                        junks[material] += quantity;
                    }
                    else
                    {
                        junks.Add(material, quantity);
                    }

                    if (materialQ["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        materialQ["shards"] -= 250;
                        LegendaryItem = true;
                        break;
                    }
                    if (materialQ["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        materialQ["fragments"] -= 250;
                        LegendaryItem = true;
                    }
                    if (materialQ["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        materialQ["motes"] -= 250;
                        LegendaryItem = true;
                    }
                }
            }

            foreach(var kvp in materialQ.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in junks)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}