using System.Text;

namespace Caesar_Cipher
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < text.Length; i++)
            {
                char ch = (char)((int)text[i] + 3);
                sb.Append(ch);
            }
            string output = sb.ToString();
            Console.WriteLine(output);  
        }
    }
}