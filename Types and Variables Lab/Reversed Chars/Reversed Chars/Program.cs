using System.Runtime.InteropServices;

namespace Reversed_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char inputA = char.Parse(Console.ReadLine());
            char inputB = char.Parse(Console.ReadLine());
            char inputC = char.Parse(Console.ReadLine());

            Console.WriteLine($"{inputC} {inputB} {inputA}");
        }
    }
}