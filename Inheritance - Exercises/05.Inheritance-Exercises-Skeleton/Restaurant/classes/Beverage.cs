using Restaurant.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Beverage : Product
{
    private double milliliters;

    public Beverage(string name, decimal price, double milliliters)
        : base(name, price)
    {
        this.Milliliters = milliliters;
    }

    public double Milliliters { get => milliliters; set => milliliters = value; }
}
