namespace Maximal_Sum
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            int[,] matrix = new int[dimensions[0], dimensions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)                                                                                       //ше ги шибам с камани
                                       .Select(int.Parse)
                                       .ToArray();
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    matrix[row, i] = numbers[i];
                }
            }

            int maxSum = 0;
            int[,] bestMatrix = new int[3, 3];

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int i = 0; i < matrix.GetLength(1) - 2; i++)
                {
                    int sum = matrix[row, i] +
                              matrix[row, i + 1] +
                              matrix[row, i + 2] +
                              matrix[row + 1, i] +
                              matrix[row + 1, i + 1] +
                              matrix[row + 1, i + 2] +
                              matrix[row + 2, i] +
                              matrix[row + 2, i + 1] +
                              matrix[row + 2, i + 2];

                    if (sum > maxSum)
                    {
                        bestMatrix[0, 0] = matrix[row, i];
                        bestMatrix[0, 1] = matrix[row, i + 1];
                        bestMatrix[0, 2] = matrix[row, i + 2];
                        bestMatrix[1, 0] = matrix[row + 1, i];
                        bestMatrix[1, 1] = matrix[row + 1, i + 1];
                        bestMatrix[1, 2] = matrix[row + 1, i + 2];
                        bestMatrix[2, 0] = matrix[row + 2, i];
                        bestMatrix[2, 1] = matrix[row + 2, i + 1];
                        bestMatrix[2, 2] = matrix[row + 2, i + 2];

                        maxSum = sum;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{bestMatrix[0, 0]} {bestMatrix[0, 1]} {bestMatrix[0, 2]}");
            Console.WriteLine($"{bestMatrix[1, 0]} {bestMatrix[1, 1]} {bestMatrix[1, 2]}");
            Console.WriteLine($"{bestMatrix[2, 0]} {bestMatrix[2, 1]} {bestMatrix[2, 2]}");
        }
    }
}
