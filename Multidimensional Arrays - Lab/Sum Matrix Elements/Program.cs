namespace Sum_Matrix_Elements
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
            for (int r = 0; r <= size[0] -1; r++)
            {
                int[] Elements = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();
                for(int h = 0; h < matrix.GetLength(1); h++)
                {
                    matrix[r, h] = Elements[h];
                }
            }
            int sum = 0;
            for(int r = 0; r < matrix.GetLength(0); r++)
            {
                for(int h = 0; h < matrix.GetLength(1); h++)
                {
                    sum += matrix[r, h];
                }
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);

        }
    }
}