namespace Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(Console.ReadLine());
            decimal output = input * 1.31m;
            Console.WriteLine(value:$"{output:f3}");
        }
    }
}