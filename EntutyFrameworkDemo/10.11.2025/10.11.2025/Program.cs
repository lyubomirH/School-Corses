using System.Security.Cryptography.X509Certificates;

namespace _10._11._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Func(3));
            Func("test");
        }
        static int Func (int num)
        {
            if (num == 0)
            {
                return 1;
            }
            return Func(num - 1) + Func(num - 1);
        }
        static void Func(string text)
        {
            int lenght = text.Length;
            if(lenght > 0)
            {
                string temp = text.Substring(0, lenght - 1);
                Func(temp);
            }
            Console.WriteLine(text);
        }
    }
}
