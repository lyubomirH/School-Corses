namespace Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    for(int k = 0; k < number; k++)
                    {
                        char charOne = (char)('a' + i);
                        char charTwo = (char)('a' + j);
                        char charThree = (char)('a' + k);

                        Console.WriteLine($"{charOne}{charTwo}{charThree}");
                    }
                }
            }
        }
    }
}