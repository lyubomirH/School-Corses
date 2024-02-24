using System.Threading.Channels;

namespace Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Action<string[]> PrintOut = names => Console.WriteLine(string.Join($"\n", names));
            PrintOut(name);
        }
    }
}