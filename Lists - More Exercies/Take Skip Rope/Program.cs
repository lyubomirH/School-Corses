using System.Text;

namespace Take_Skip_Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            List<int> numbers = NewList();
            List<int> take = NewList();
            List<int> skip = NewList();
            StringBuilder result = new StringBuilder();         // не се сещам как да ги заиша в лист. И потърсих в интернет и намерих това.
            List<string> NotANumber = new List<string>();

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    numbers.Add(int.Parse(word[i].ToString()));
                }
                else
                {
                    NotANumber.Add(word[i].ToString());
                }

            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    take.Add(numbers[i]);
                }
                else
                {
                    skip.Add(numbers[i]);
                }
            }

            int indexForSkip = 0;

            for (int i = 0; i < take.Count; i++)
            {
                List<string> temp = new List<string>(NotANumber);
                temp = temp.Skip(indexForSkip).Take(take[i]).ToList();
                result.Append(string.Join("", temp));
                indexForSkip += take[i] + skip[i];
            }
            Console.WriteLine(result.ToString());
        }
        static List<int> NewList ()
        {
            return new List<int> 
        }
    }
}