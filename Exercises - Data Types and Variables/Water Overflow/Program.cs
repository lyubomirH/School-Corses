namespace Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int receive = int.Parse(Console.ReadLine());
            int sum = 0;
            
            for (int i = 0 ; receive > i ; i++ )
            {
                int water = int.Parse(Console.ReadLine());
                if (sum + water > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += water;
                }
            }
            Console.WriteLine(sum);
        }
    }
}