namespace PolymorphismExercises.Vehicles
{
    public class Truck : Vehicle
    {
        public override double AirConditionerConsumption => 1.6;

        public Truck(double fuelQuantity, double fuelConsumptionPerKm)
            : base(fuelQuantity, fuelConsumptionPerKm) { }

        public override void Refuel(double fuel)
        {
            base.Refuel(fuel * 0.95);
        }
    }
}