namespace Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> clothValues = Console.ReadLine().Split(' ').Select(int.Parse).Reverse().ToList();
            int capacity = int.Parse(Console.ReadLine());

            int racks = 0;
            int sum = 0;

            Stack<int> box = new Stack<int>(clothValues);

            while (box.Count > 0)
            {
                int currentSize = sum + box.Peek();

                if (currentSize < capacity)
                {
                    sum += box.Pop();
                }
                else if (currentSize == capacity)
                {
                    racks++;
                    box.Pop();
                    sum = 0;
                }
                else
                {
                    racks++;
                    sum = box.Pop();
                }
            }

            if (sum > 0)
            {
                racks++;
            }

            Console.WriteLine(racks);
        }
    }
}