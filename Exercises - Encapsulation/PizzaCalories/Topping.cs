using System;
using System.Collections.Generic;
using System.Globalization;

public class Topping
{
    private string toppingType;
    private double weight;

    private static readonly Dictionary<string, double> ToppingModifiers = new()
    {
        { "Meat", 1.2 },
        { "Veggies", 0.8 },
        { "Cheese", 1.1 },
        { "Sauce", 0.9 }
    };

    public Topping(string toppingType, double weight)
    {
        ToppingType = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(toppingType.ToLower());
        Weight = weight;
    }

    public string ToppingType
    {
        get => toppingType;
        private set
        {
            if (!ToppingModifiers.ContainsKey(value))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            toppingType = value;
        }
    }

    public double Weight
    {
        get => weight;
        private set
        {
            if (value < 1 || value > 50)
            {
                throw new ArgumentException($"{ToppingType} weight should be in the range [1..50].");
            }
            weight = value;
        }
    }

    public double CalculateCalories()
    {
        return 2 * weight * ToppingModifiers[toppingType];
    }
}
