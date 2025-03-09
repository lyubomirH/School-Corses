using System;
using System.Collections.Generic;
using System.Linq;

public class Pizza
{
    private string name;
    private List<Topping> toppings;

    public Pizza(string name, Dough dough)
    {
        Name = name;
        Dough = dough;
        toppings = new List<Topping>();
    }

    public string Name
    {
        get => name;
        private set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            name = value;
        }
    }

    public Dough Dough { get; private set; }

    public int NumberOfToppings => toppings.Count;

    public void AddTopping(Topping topping)
    {
        if (toppings.Count >= 10)
        {
            throw new ArgumentException("Number of toppings should be in range [0..10].");
        }
        toppings.Add(topping);
    }

    public double CalculateTotalCalories()
    {
        return Dough.CalculateCalories() + toppings.Sum(t => t.CalculateCalories());
    }

    public override string ToString()
    {
        return $"{Name} - {CalculateTotalCalories():F2} Calories.";
    }
}
