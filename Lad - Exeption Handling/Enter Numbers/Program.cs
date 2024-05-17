using System.Runtime.CompilerServices;
using System.Text;

namespace Enter_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int[] arr = new int[10];

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 10; i++) 
            {
                arr[i] = ReadNumber(start, end);
            }
            Console.WriteLine(string.Join());
            int ReadNumber(int start, int end)
            {
                string input = Console.ReadLine();
                
                try
                {
                    int number = int.Parse(input);
                    if (number <= start || number >= end)
                    {
                        throw new ArgumentOutOfRangeException($"Your number is not in range ({start} - {end})!");
                    }
                    return number;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Invalid Number!");
                }
                return 0;
            }
        }
    }
}
