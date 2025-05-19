namespace PolymorphismExercises.VehiclesExtension
{
    public class Truck : Vehicle
    {
        public override double AirConditionerConsumption => 1.6;

        public Truck(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
            : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity) { }

        public override void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }

            double fuelToAdd = fuel * 0.95;
            if (FuelQuantity + fuelToAdd > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            }
            else
            {
                FuelQuantity += fuelToAdd;
            }
        }
    }
}