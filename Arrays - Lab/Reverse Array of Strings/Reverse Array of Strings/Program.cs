namespace Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] output = new string[input.Length];

            for (int i = input.Length; i >= 0 ; i--)
            {
                output[i] = input[i];
            }
            Console.WriteLine(string.Join(" ", input.Reverse()));
        }
    }
}