namespace CarsModels
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Cars> cars = new List<Cars>();
            cars.Add(new Cars("Volkswagen", 500, 2001, "CA1455KA", false));
            cars.Add(new Cars("BMW", 5000, 2005, "PK1254MN", false));
            cars.Add(new Cars("Mitsubishi", 5000, 2004, "CB7832EU", false));
            cars.Add(new Cars("KIA", 10000, 2010, "A7633OP", false));
            cars.Add(new Cars("Tesla", 50000, 2023, "EA2137XT", true));
            cars.Add(new Cars("Mercedes", 25000, 2019, "CB3612HP", false));
            cars.Add(new Cars("Audi", 45000, 2022, "CA9999XX", false));

            var query1 = from car in cars
                         where car.Year > 2010
                         select car;
            var query2 = from car in cars
                         where car.LicencePlate.StartsWith("CA") || car.LicencePlate.StartsWith("CB")
                         select car;
            var query3 = from car in cars
                         where !car.IsElectric
                         select car;
            var query4 = from car in cars
                         where car.Price >= 20000 && car.Price <= 50000
                         select car;
            var query5 = from car in cars
                         where car.Brand == "BMW" || car.Brand == "Audi" || car.Brand == "Mercedes"
                         select car;

            Console.WriteLine("Коли произведени след 2010 година:");
            foreach (var car in query1)
            {
                Console.WriteLine($"{car.Brand} ({car.LicencePlate}) е от {car.Year} година.");
            }
            Console.WriteLine();
            Console.WriteLine("Коли с регистрационни номера от София:");
            foreach (var car in query2)
            {
                Console.WriteLine($"{car.Brand} ({car.LicencePlate}) е регистрирана в София.");
            }
            Console.WriteLine();
            Console.WriteLine("Неелектрически коли:");
            foreach (var car in query3)
            {
                Console.WriteLine($"{car.Brand} ({car.LicencePlate}) не е електрическа кола.");
            }
            Console.WriteLine();
            Console.WriteLine("Коли в ценови диапазон 20 000 - 50 000 евро:");
            foreach (var car in query4)
            {
                Console.WriteLine($"{car.Brand} ({car.LicencePlate}) струва {car.Price} евро.");
            }
            Console.WriteLine();
            Console.WriteLine("Коли от следните марки: BMW, Audi, Mercedes:");
            foreach (var car in query5)
            {
                Console.WriteLine($"{car.Brand} ({car.LicencePlate})");
            }
        }
    }
}