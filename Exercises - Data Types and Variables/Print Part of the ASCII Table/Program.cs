namespace Print_Part_of_the_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (;start <= end; start++)
            {
                char leter = (char)start;
                Console.Write($"{leter} ");
            }
        }
    }
}