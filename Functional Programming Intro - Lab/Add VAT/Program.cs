namespace Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => x * 1.2)
                .ToArray();
            foreach(var i in numbers)
            {
                Console.WriteLine($"{i:f2}");
            }
        }
    }
}