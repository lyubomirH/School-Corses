namespace Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] splitWord = word.ToArray();
            IsItEven(splitWord);

        }
        static void IsItEven(char[] splitWord)
        {
            if (splitWord.Length % 2 == 1)
            {
                double charPlais = (splitWord.Length / 2);
                double raund = Math.Floor(charPlais);
                int final = (int)raund;
                Console.WriteLine($"{splitWord[final]}");
            }
            else
            {
                int charPlais = (splitWord.Length / 2 );
                int charPlaisTwo = charPlais + 1;

                Console.WriteLine($"{splitWord[charPlaisTwo]}{splitWord[charPlais]}");
            }

        }
    }
}