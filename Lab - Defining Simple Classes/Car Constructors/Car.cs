using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Constructors
{
    internal class Car
    {
        public string? make;
        public string? model;
        public int year;
        public double fuelQuantity;
        public double fuelConsumption;

        private string Make { get; set; }
        private string Model { get; set; }
        private int Year { get; set; }
        private double FuelQuantity { get; set; }
        private double FuelConsumption 
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }
        public Car()
        {
            this.Make = "VW";
            this.Make = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }
        public Car(string make, string model, int year) : this() 
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;

        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;

        } 
        //public void Drive(double distans)
        //{
        //    double fuelNeededForDistans = distans * fuelConsumption;
        //    if (fuelQuantity - fuelNeededForDistans > 0)
        //    {
        //        double leftFuel = fuelQuantity - fuelNeededForDistans;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not enough fuel to perform this trip!");
        //    }
        //}
        //public string WhoAmI()
        //{
        //    return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L";
        //}
    }
}
