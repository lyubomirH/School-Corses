namespace Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string result = "";
            foreach (string word in words)
            {
                int repeatTimes = word.Length;
                for(int i = repeatTimes - 1; i >= 0; i--)
                {
                    result += word;
                }
            }
            Console.WriteLine(result);
        }
    }
}