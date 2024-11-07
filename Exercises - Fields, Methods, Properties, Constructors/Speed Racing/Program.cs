using System.Reflection;

namespace Speed_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                var carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionPerKm = double.Parse(carInfo[2]);

                cars[model] = new Car(model, fuelAmount, fuelConsumptionPerKm);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var tokens = command.Split();
                string action = tokens[0];
                string carModel = tokens[1];
                double amountOfKm = double.Parse(tokens[2]);

                if (action == "Drive" && cars.ContainsKey(carModel))
                {
                    cars[carModel].Drive(amountOfKm);
                }
            }

            foreach (var car in cars.Values)
            {
                Console.WriteLine(car);
            }
        }
    }
}
