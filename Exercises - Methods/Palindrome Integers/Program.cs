namespace Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintIfPalindrome();
        }
        public static void PrintIfPalindrome()
        {
            string reversedString = string.Empty;

            while (true)
            {
                string inputedString = Console.ReadLine();

                if (inputedString == "END")
                {
                    break;
                }

                for (int i = inputedString.Length - 1; i >= 0; i--)
                {
                    reversedString += inputedString[i];
                }

                if (reversedString == inputedString)
                {
                    Console.WriteLine("true");
                }

                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }

}