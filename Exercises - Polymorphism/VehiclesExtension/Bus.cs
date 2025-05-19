namespace PolymorphismExercises.VehiclesExtension
{
    public class Bus : Vehicle
    {
        public override double AirConditionerConsumption => 1.4;

        public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
            : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity) { }

        public void DriveEmpty(double distance)
        {
            base.Drive(distance, false);
        }
    }
}