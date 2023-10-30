namespace Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            IsNumPostiv(num);
        }
        static void IsNumPostiv (int num)
        {
            if (num >= 1)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num == 0)
            {
                Console.WriteLine("The number 0 is zero.");
            }
            else
            {
                Console.WriteLine($"The number {num} is negative.");
            }
        }
    }
}