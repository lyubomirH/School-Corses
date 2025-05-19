namespace PolymorphismExercises.Vehicles
{
    public class Car : Vehicle
    {
        public override double AirConditionerConsumption => 0.9;

        public Car(double fuelQuantity, double fuelConsumptionPerKm)
            : base(fuelQuantity, fuelConsumptionPerKm) { }
    }
}