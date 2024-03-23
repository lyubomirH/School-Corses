namespace Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int result = 0;
            string alphabet = "ABCDEFGHIJKLMNOPQSTUWXYZ";
            foreach (string s in input)
            {
                int calcNum = getNums(s);
                if (s[0] == s.ToLower()[0])
                {
                    alphabet.IndexOf(s);
                }
                else
                {
                    calcNum /= alphabet.IndexOf(s[0]);
                }
                if (s[s.Length - 1] == s.ToLower()[s.Length - 1])
                {

                }
            }
        }
        static int getNums(string calculation)
        {
            int result = 0;
            foreach(char c in calculation)
            {
                if (char.IsDigit(c))
                {
                    result += c;
                }
            }
            return result;
        }
    }
}