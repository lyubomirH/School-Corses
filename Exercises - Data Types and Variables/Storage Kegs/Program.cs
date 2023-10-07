namespace Storage_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            string NameOfTheBest = "";
            double sumOfTheBest = 0;
            for (int i = 0 ; i < numberOfKegs ; i++)
            {
                string nama = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());
                double sum = 0;
                sum = Math.PI * (r * r) * h;
                if (sum > sumOfTheBest)
                {
                    sumOfTheBest = sum;
                    NameOfTheBest = nama;
                }
            }
            Console.WriteLine(NameOfTheBest);
        }
    }
}