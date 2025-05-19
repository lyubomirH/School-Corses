using Restaurant.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Food> food = new List<Food>();
            List<Beverage> beverage = new List<Beverage>();
            List<Dessert> desert = new List<Dessert>();
            while (input != "End")
            {
                string[] tokens = input.Split(' ');
                string orderType = tokens[0];
                string name = tokens[1];
                switch (orderType)
                {
                    case "Fish":
                        decimal fishProce = decimal.Parse(tokens[2]);
                        var fish = new Fish(name, fishProce);
                        food.Add(fish);
                        break;

                    case "Tea":
                        decimal teaProce = decimal.Parse(tokens[2]);
                        double TeaMillilitres = double.Parse(tokens[3]);
                        var tea = new Tea(name, teaProce, TeaMillilitres);
                        beverage.Add(tea);
                        break;

                    case "Coffee":
                        double caffeine = double.Parse(tokens[2]);
                        var coffee = new Coffee(name, caffeine);
                        beverage.Add(coffee);
                        break;

                    case "Soup":
                        decimal SoupPrice = decimal.Parse(tokens[2]);
                        double SuupGrams = double.Parse(tokens[3]);
                        var soup = new Soup(name, SoupPrice, SuupGrams);
                        food.Add(soup);
                        break;

                    case "Cake":
                        var cake = new Cake(name);
                        desert.Add(cake);
                        break;

                    default:
                        Console.WriteLine("Error: invalid input");
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(WriteOutput(food, beverage, desert));
        }

        private static string WriteOutput(List<Food> foods, List<Beverage> beverages, List<Dessert> desert)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Your order contains:");
            sb.AppendLine($"  Quantity of liquids: {beverages.Sum(b  => b.Milliliters)}");
            sb.AppendLine($"  Grams of foods {foods.Sum(f => f.Grams) + desert.Sum(d => d.Calories)}");
            

            if(desert.Count() > 0)
            {
                sb.AppendLine();
            }
            sb.AppendLine($"  Calories: {desert.Sum(d => d.Calories):f2}");
            return sb.ToString();
        }
    }
}