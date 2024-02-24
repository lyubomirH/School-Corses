using System.Text;

namespace Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                         .Split()
                         .ToList();

            if (input.Count > 1)
            {
                Merge(input);
            }
            char[] word = input[0].ToCharArray();
            Dictionary<char, int> numberChar = new Dictionary<char, int>();
            foreach (var kvp in word)
            {
                if (!numberChar.ContainsKey(kvp))
                {
                    numberChar[kvp] = 0;
                }

                numberChar[kvp]++;
            }
            foreach (var kvp in numberChar)
            {
                Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
            }
        }
        static void Merge(List<string> first)
        {
            StringBuilder currentWord = new StringBuilder();
            for (int i = 0; i < first.Count; i++)
            {
                currentWord.Append(first[i]);
            }
            first.RemoveRange(0, first.Count - 1);
            first.Insert(0, currentWord.ToString());
        }
    }
}