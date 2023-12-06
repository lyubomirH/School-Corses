namespace Squared_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Square(number));
            static int Square(int x) => x * x;
        }
    }
}