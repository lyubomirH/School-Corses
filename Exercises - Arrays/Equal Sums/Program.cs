namespace Equal_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            bool isNotASum = false;
            for (int i = 0; i < arr.Length; i++ )
            {
                int sumLeft = 0;
                for (int j = 0; j<i; j++)
                {
                    sumLeft += arr[j];
                }
                int sumRight = 0;
                for (int f = arr.Length - 1; f > i; f--)
                {
                    sumRight += arr[f];
                }
                if (sumLeft == sumRight && !isNotASum)
                {
                    Console.WriteLine(i);
                    isNotASum = true;
                }
            }

            if (!isNotASum)
            {
                Console.WriteLine("no");
            }
        }
    }
}