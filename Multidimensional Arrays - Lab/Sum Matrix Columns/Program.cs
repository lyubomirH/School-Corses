namespace Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[size[0], size[1]];
            for (int r = 0; r <= size[0] - 1; r++)
            {
                int[] Elements = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = Elements[c];
                }
            }
            for(int c = 0; c < matrix.GetLength(1); c++)
            {
                int sum = 0;
                for(int r = 0; r <matrix.GetLength(0); r++)
                {
                    sum += matrix[r, c];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
