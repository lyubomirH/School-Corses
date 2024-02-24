using System.Security.Cryptography.X509Certificates;

namespace Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();
            for(int i = 0; i < num; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }
            foreach(var numOUTPUT in names)
            {
                Console.WriteLine(numOUTPUT);
            }
        }
    }
}