using System;

namespace PolymorphismExercises.VehiclesExtension
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double tankCapacity;

        public double FuelQuantity
        {
            get => fuelQuantity;
            protected set
            {
                if (value > TankCapacity)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }
            }
        }

        public double FuelConsumptionPerKm { get; }
        public virtual double AirConditionerConsumption { get; }
        public double TankCapacity
        {
            get => tankCapacity;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }
                tankCapacity = value;
            }
        }

        protected Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public virtual void Drive(double distance, bool hasPeople = true)
        {
            double consumption = hasPeople
                ? FuelConsumptionPerKm + AirConditionerConsumption
                : FuelConsumptionPerKm;

            double neededFuel = distance * consumption;

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
            if (fuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }

            if (FuelQuantity + fuel > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            }
            else
            {
                FuelQuantity += fuel;
            }
        }
    }
}