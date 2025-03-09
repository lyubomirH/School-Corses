using System;
using System.Collections.Generic;
using System.Globalization;

public class Dough
{
    private string flourType;
    private string bakingTechnique;
    private double weight;

    private static readonly Dictionary<string, double> FlourModifiers = new()
    {
        { "White", 1.5 },
        { "Wholegrain", 1.0 }
    };

    private static readonly Dictionary<string, double> BakingModifiers = new()
    {
        { "Crispy", 0.9 },
        { "Chewy", 1.1 },
        { "Homemade", 1.0 }
    };

    public Dough(string flourType, string bakingTechnique, double weight)
    {
        FlourType = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(flourType.ToLower());
        BakingTechnique = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(bakingTechnique.ToLower());
        Weight = weight;
    }

    public string FlourType
    {
        get => flourType;
        private set
        {
            if (!FlourModifiers.ContainsKey(value))
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            flourType = value;
        }
    }

    public string BakingTechnique
    {
        get => bakingTechnique;
        private set
        {
            if (!BakingModifiers.ContainsKey(value))
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            bakingTechnique = value;
        }
    }

    public double Weight
    {
        get => weight;
        private set
        {
            if (value < 1 || value > 200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
            weight = value;
        }
    }

    public double CalculateCalories()
    {
        return 2 * weight * FlourModifiers[flourType] * BakingModifiers[bakingTechnique];
    }
}
