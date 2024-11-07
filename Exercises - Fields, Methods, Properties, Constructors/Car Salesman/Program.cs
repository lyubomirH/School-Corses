namespace Car_Salesman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();

            for (int i = 0; i < n; i++)
            {
                var engineInfo = Console.ReadLine().Split();
                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);

                int? displacement = engineInfo.Length > 2 && int.TryParse(engineInfo[2], out int disp) ? disp : (int?)null;
                string efficiency = engineInfo.Length == 4 ? engineInfo[3] : "n/a";

                engines[model] = new Engine(model, power, displacement, efficiency);
            }

            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < m; i++)
            {
                var carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                Engine engine = engines[carInfo[1]];

                int? weight = carInfo.Length > 2 && int.TryParse(carInfo[2], out int w) ? w : (int?)null;
                string color = carInfo.Length == 4 ? carInfo[3] : "n/a";

                cars.Add(new Car(model, engine, weight, color));
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
