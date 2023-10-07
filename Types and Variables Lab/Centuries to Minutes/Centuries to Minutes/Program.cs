namespace Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int day = (int)(years * 365.2422);
            int hours = day * 24;
            decimal minutes = hours * 60;

            Console.WriteLine(value:$"{centuries:f0} centuries = {years:f0} years = {day:f0} days = {hours:f0} hours = {minutes:f0} minutes");
        }
    }
}