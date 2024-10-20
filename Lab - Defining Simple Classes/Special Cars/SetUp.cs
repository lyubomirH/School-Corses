namespace Special_Cars
{
    internal class SetUp
    {
        static void Main(string[] args)
        {
            List<TireSet> tires = new List<TireSet>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "No more tires")
                    break;

                double[] tireData = input.Split().Select(double.Parse).ToArray();
                List<(int, double)> tirePairs = new List<(int, double)>();

                for (int i = 0; i < tireData.Length; i += 2)
                {
                    tirePairs.Add(((int)tireData[i], tireData[i + 1]));
                }
                tires.Add(new TireSet(tirePairs));
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Engines done")
                    break;

                int[] engineData = input.Split().Select(int.Parse).ToArray();
                int horsePower = engineData[0];
                double cubicCapacity = engineData[1];

                engines.Add(new Engine(horsePower, cubicCapacity));
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Show special")
                    break;

                string[] carData = input.Split();
                string make = carData[0];
                string model = carData[1];
                int year = int.Parse(carData[2]);
                double fuelQuantity = double.Parse(carData[3]);
                double fuelConsumption = double.Parse(carData[4]);
                int engineIndex = int.Parse(carData[5]);
                int tiresIndex = int.Parse(carData[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]);
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && car.Tires.GetPressureSum() >= 9 && car.Tires.GetPressureSum() <= 10)
                {
                    car.Drive(20);
                    Console.WriteLine($"Make: {car.Make}");
                    Console.WriteLine($"Model: {car.Model}");
                    Console.WriteLine($"Year: {car.Year}");
                    Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                    Console.WriteLine($"FuelQuantity: {car.FuelQuantity:F1}");
                }
            }
        }
    }
}
