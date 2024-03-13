using System.Text;

namespace Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            StringBuilder text = new StringBuilder(Console.ReadLine());
            foreach (string word in bannedWords)
            {
                StringBuilder NewWord = new StringBuilder();
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    NewWord.Append("*");
                }
                string newWord = NewWord.ToString();
               text.Replace(word, newWord);
            }
            string newText = text.ToString();
            Console.WriteLine(newText);

        }
    }
}
