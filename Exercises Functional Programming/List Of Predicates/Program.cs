namespace List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] divisors = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();

            Func<int, int, bool> filter = (x, y) => x % y == 0;
            List<int> divisibleNums = new List<int>();
            bool divisible = true;
            for(int i = 1; i <= n; i++)
            {
                divisible = true;
                for(int j = 0; j < divisors.Length ; j++)
                {
                    if (!filter(i, divisors[j]))
                    {
                        divisible = false;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (divisible == true)
                {
                    divisibleNums.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", divisibleNums));
        }
    }
}