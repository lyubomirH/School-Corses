namespace Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0; 
            for (int i = 0; i < n; i++) 
            {
                int number = char.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine($"The sum equals: {sum:f0}");
        }
    }
}