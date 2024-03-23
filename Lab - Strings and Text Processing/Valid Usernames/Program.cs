using System.Text;

namespace Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();
            foreach (string neme in input)
            {
                if(neme.Length >= 3 && neme.Length <= 16 
                    && ChekForNumsLetters(neme))
                {
                    result.AppendLine(neme);
                }
            }
            Console.WriteLine(result.ToString());
        }
        static bool ChekForNumsLetters(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsLetter(c) && !char.IsDigit(c) && c == '-' && c == '_' && c == '!')
                {
                    return false;
                }
            }
            return true;
        }
    }
}