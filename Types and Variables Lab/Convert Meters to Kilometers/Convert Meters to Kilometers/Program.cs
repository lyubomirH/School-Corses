namespace Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(Console.ReadLine());
            decimal output = input / 1000;
            Console.WriteLine(value:$"{output:f2}");
        }
    }
}