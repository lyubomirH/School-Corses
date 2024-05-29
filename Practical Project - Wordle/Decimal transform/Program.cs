using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;

namespace Decimal_transform
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder tipe = new StringBuilder();
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            tipe.Append(input[0]);
            tipe.Append(input[1]);
            string tipeInString = tipe.ToString(); 
            input.RemoveAt(0);
            input.RemoveAt(0);

            int Number = 0;
            if (tipeInString == "0B")                // 2
            {
                int y = 0;
                List<int> counts = new List<int>();
                for(int i = input.Count; i <= 0; i--)
                {
                    int num = int.Parse(input[y]);
                    double mat = num * Math.Pow(2, i);
                    counts.Add(num);
                    y++;
                }
                y = 0;
                
                for(int i = counts.Count; i <= 0; i--)
                {
                    int num = counts[i];
                    Number += num;
                    y++;
                }
            }
            else if (tipe == "0x")          // 16
            {

            }

            Console.WriteLine($"In decimal is {Number}");
        }
    }
}
