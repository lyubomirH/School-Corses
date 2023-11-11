namespace Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());

            ASCIIcaunt(one, two);
        }
        static void ASCIIcaunt(char one, char two)
        {
            int charOne = one;
            int charTwo = two;
            if (charOne < charTwo)
            {
                for (int i = charOne + 1; i < charTwo; i++)
                {
                    char output = (char)i;
                    Console.Write($"{output} ");
                }
            }
            if (charTwo < charOne)
            {
                for (int i = charTwo + 1; i < charOne; i++)
                {
                    char output = (char)i;
                    Console.Write($"{output} ");
                }
            }
        }
    }
}