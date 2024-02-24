namespace Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sortedSet = new SortedSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                foreach (var item in line)
                {
                    sortedSet.Add(item);
                }
            }

            foreach (var item in sortedSet)
            {
                Console.Write($"{item} ");
            }
        }
    }
}