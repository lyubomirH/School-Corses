using System.Diagnostics;

namespace zad._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(num));
            }
            catch 
            {
                Console.WriteLine("Invalit number");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
