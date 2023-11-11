using System.Diagnostics;
using System.Xml.Linq;

namespace Student_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = int.Parse(Console.ReadLine());
            GetStudensDate(name, grade); 
        }
        void GetStudensDate(string name, int grade)
        {
            Console.WriteLine($"{name} is studying in {grade} grade.");
        }
    }
}