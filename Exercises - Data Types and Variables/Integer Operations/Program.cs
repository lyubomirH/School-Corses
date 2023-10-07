namespace Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            long plus = long.Parse(Console.ReadLine());
            long division = long.Parse(Console.ReadLine());
            long multiplication = long.Parse(Console.ReadLine());

            number += plus;
            number /= division;
            number *= multiplication;

            Console.WriteLine(number);
        }
    }
}