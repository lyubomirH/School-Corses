using System;
using System.Reflection;

namespace Offroad_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> fuelIntegers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            List<int> consumptionIndexes = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList(); 
            List<int> quantitiesIndexes = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            Stack<int> fuel = new Stack<int>(fuelIntegers);
            Queue<int> consumption = new Queue<int>(consumptionIndexes);
            Queue<int> quantities = new Queue<int>(quantitiesIndexes);

            for(int i = 0; i < fuelIntegers.Count; i++)
            {
                int consumptionIndexFuel = fuel.Pop() - consumption.Dequeue();
                if (consumptionIndexFuel >= quantities.Dequeue())
                {
                    Console.WriteLine($"John has reached: Altitude {i + 1}");
                }
                else 
                {
                    Console.WriteLine($"John did not reach: Altitude {i + 1}");
                    Console.WriteLine("John failed to reach the top.");
                    Console.Write($"Reached altitudes: ");
                    for (int j = 1; i > j -1; j++)
                    {
                        if (j == 1)
                        {
                            Console.Write($"Altitude {j}");
                        }
                        Console.Write($" ,Altitude {j}");
                    }
                    break;
                }
            }
        }
    }
}