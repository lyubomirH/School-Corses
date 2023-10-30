using System.Globalization;

namespace Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string text = Console.ReadLine();
           int time = int.Parse(Console.ReadLine());
            NewText(text, time);
        }
        static void NewText (string text, int n) 
        {
            
            for (int i = 0; i< n; i++)
            {

                Console.Write(text);
            }
        }
    }
}