namespace Town_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int id = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {name} has population of {id} and area {num} square km.");
        }
    }
}
