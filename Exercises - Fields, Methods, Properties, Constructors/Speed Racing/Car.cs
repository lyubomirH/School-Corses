using Speed_Racing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Speed_Racing
{
    internal class Car
    {
        public string Model { get; }
        public double FuelAmount { get; private set; }
        public double FuelConsumptionPerKm { get; }
        public double TraveledDistance { get; private set; }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
            TraveledDistance = 0;
        }

        public bool Drive(double distance)
        {
            double neededFuel = distance * FuelConsumptionPerKm;

            if (FuelAmount >= neededFuel)
            {
                FuelAmount -= neededFuel;
                TraveledDistance += distance;
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return false;
            }
        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:F2} {TraveledDistance}";
        }
    }
}
