namespace Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                                      .Split(" ")
                                      .Select(int.Parse)
                                      .ToArray();

            string[,] matrix = new string[dimensions[0], dimensions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] numbers = Console.ReadLine()
                                       .Split(" ")
                                       .ToArray();
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    matrix[row, i] = numbers[i];
                }
            }
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int i = 0; i < matrix.GetLength(1) - 1; i++)
                {
                    string topLeft = matrix[row, i];
                    string topReth = matrix[row, i + 1];
                    string downLeft = matrix[row + 1, i];
                    string downReth = matrix[row + 1, i + 1];

                    if (topLeft == topReth && 
                        downLeft == downReth && 
                        topLeft == downReth && 
                        topReth == downReth)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}