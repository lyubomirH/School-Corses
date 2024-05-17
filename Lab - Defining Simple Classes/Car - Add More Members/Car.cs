using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car___Add_More_Members
{
    public class Car
    {
        public string? make;
        public string? model;
        public int year;
        public double fuelQuantity;
        public double fuelConsumption;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distans)
        {
            double fuelNeededForDistans = distans * fuelConsumption;
            if(fuelQuantity - fuelNeededForDistans > 0)
            {
                double leftFuel = fuelQuantity - fuelNeededForDistans;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel:\r\n{this.FuelQuantity:F2}L";
        }
    }
}
