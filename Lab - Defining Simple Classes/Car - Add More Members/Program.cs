namespace Car___Add_More_Members
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "VM";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;
            Console.WriteLine(car.WhoAmI());
        }
    }
}
