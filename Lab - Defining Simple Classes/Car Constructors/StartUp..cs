namespace Car_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car firstCar = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);
            Console.WriteLine($"{firstCar.make} {firstCar.model} {firstCar.year} {firstCar.fuelConsumption} {firstCar.fuelQuantity}");
            Console.WriteLine($"{secondCar.make} {secondCar.model} {secondCar.year} {secondCar.fuelConsumption} {secondCar.fuelQuantity}");
            Console.WriteLine($"{thirdCar.make} {thirdCar.model} {thirdCar.year} {thirdCar.fuelConsumption} {thirdCar.fuelQuantity}");
        }
    }
}
