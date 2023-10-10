namespace Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num ; i++)
            {
                for(int j = arr.Length - 1; j >= 0; j--)
                {
                    int temp = arr[arr.Length - 1];
                    arr[arr.Length - 1] = arr[j];
                    arr[j] = temp;
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}