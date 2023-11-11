using System.Diagnostics.Tracing;
using System.Net.Http.Headers;

namespace Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            WordSover(word);
        }
        static void WordSover(string word)
        {
            int count = 0;
            char[] signiher = word.ToCharArray();
            for (int i = 0; i < signiher.Length ; i++)
            {
                if (signiher[i] == 'A' || signiher[i] == 'a' || signiher[i] == 'E' || signiher[i] == 'e' || signiher[i] == 'O' || signiher[i] == 'o' || signiher[i] == 'U' || signiher[i] == 'u' || signiher[i] == 'I' || signiher[i] == 'i')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}