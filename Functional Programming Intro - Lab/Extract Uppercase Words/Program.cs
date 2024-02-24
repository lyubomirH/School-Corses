using System;

namespace Extract_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] uppercase = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(n => n[0] == n.ToUpper()[0])
                .ToArray();

            foreach (var i in uppercase)
            {
                Console.WriteLine(i);
            }
        }
    }
}