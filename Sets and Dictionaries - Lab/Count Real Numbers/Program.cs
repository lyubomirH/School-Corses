namespace Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            var counts = new SortedDictionary<double, int>();

            foreach (var num in input)
            {
                double parsedNum = double.Parse(num);
                if (counts.ContainsKey(parsedNum))
                {
                    counts[parsedNum]++;
                }
                else
                {
                    counts[parsedNum] = 1;
                }
            }

            foreach (var num in counts.Keys)
            {
                Console.WriteLine("{0} -> {1}", num, counts[num]);
            }
        }
    }
}