using System;

namespace PolymorphismExercises.Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        public double FuelQuantity
        {
            get => fuelQuantity;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }
                fuelQuantity = value;
            }
        }

        public double FuelConsumptionPerKm { get; set; }
        public virtual double AirConditionerConsumption { get; }

        protected Vehicle(double fuelQuantity, double fuelConsumptionPerKm)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public virtual void Drive(double distance)
        {
            double neededFuel = distance * (FuelConsumptionPerKm + AirConditionerConsumption);

            if (FuelQuantity >= neededFuel)
            {
                FuelQuantity -= neededFuel;
                Console.WriteLine($"{GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
        }

        public virtual void Refuel(double fuel)
        {
            FuelQuantity += fuel;
        }
    }
}