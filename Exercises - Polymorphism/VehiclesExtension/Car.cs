namespace PolymorphismExercises.VehiclesExtension
{
    public class Car : Vehicle
    {
        public override double AirConditionerConsumption => 0.9;

        public Car(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
            : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity) { }
    }
}