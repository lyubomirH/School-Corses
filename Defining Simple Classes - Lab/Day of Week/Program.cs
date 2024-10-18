using System.Globalization;
namespace Day_of_Week
{
    class Program
    {
        static void Main()
        {
            string inputDate = Console.ReadLine();
            string[] parts = inputDate.Split('-');

            int day = int.Parse(parts[0]);
            int month = int.Parse(parts[1]);
            int year = int.Parse(parts[2]);
            DateTime date = new DateTime(year, month, day);
            string dayOfWeek = date.DayOfWeek.ToString();

            Console.WriteLine(dayOfWeek);
        }
    }

}
