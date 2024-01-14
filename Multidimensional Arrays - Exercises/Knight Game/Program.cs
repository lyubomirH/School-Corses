namespace Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowElements = Console.ReadLine().ToCharArray();
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    matrix[row, i] = rowElements[i];
                }
            }                                                             
                                                                         
            int attackableKnights = 0;                                                                
            int maxAttackableKnights = -1;                               
            int bestKnightRow = 0;                                        
            int bestKnightCol = 0;                                        
            int count = 0;                                                
                                                                          
            while (true)                                                  
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int i = 0; i < matrix.GetLength(1); i++)
                    {
                        if (matrix[row, i] == 'K')
                        {

                            if (row + 1 < matrix.GetLength(0))
                            {
                                if (i - 2 >= 0)
                                {
                                    if (matrix[row + 1, i - 2] == 'K')
                                    {
                                        attackableKnights++;
                                    }
                                }

                                if (i + 2 < matrix.GetLength(1))
                                {
                                    if (matrix[row + 1, i + 2] == 'K')
                                    {
                                        attackableKnights++;
                                    }
                                }
                            }


                            if (row - 1 >= 0)
                            {
                                if (i - 2 >= 0)
                                {
                                    if (matrix[row - 1, i - 2] == 'K')
                                    {
                                        attackableKnights++;
                                    }
                                }

                                if (i + 2 < matrix.GetLength(1))
                                {
                                    if (matrix[row - 1, i + 2] == 'K')
                                    {
                                        attackableKnights++;
                                    }
                                }
                            }

                            if (row + 2 < matrix.GetLength(0))
                            {
                                if (i + 1 < matrix.GetLength(1))
                                {
                                    if (matrix[row + 2, i + 1] == 'K')
                                    {
                                        attackableKnights++;
                                    }
                                }

                                if (i - 1 >= 0)
                                {
                                    if (matrix[row + 2, i - 1] == 'K')
                                    {
                                        attackableKnights++;
                                    }
                                }
                            }

                            if (row - 2 >= 0)
                            {
                                if (i + 1 < matrix.GetLength(1))
                                {
                                    if (matrix[row - 2, i + 1] == 'K')
                                    {
                                        attackableKnights++;
                                    }
                                }

                                if (i - 1 >= 0)
                                {
                                    if (matrix[row - 2, i - 1] == 'K')
                                    {
                                        attackableKnights++;
                                    }
                                }
                            }
                        }

                        if (attackableKnights > maxAttackableKnights)
                        {
                            maxAttackableKnights = attackableKnights;
                            bestKnightRow = row;
                            bestKnightCol = i;
                        }
                        attackableKnights = 0;
                    }
                }

                if (maxAttackableKnights != 0)
                {
                    matrix[bestKnightRow, bestKnightCol] = '0';
                    maxAttackableKnights = 0;
                    count++;
                }
                else
                {
                    Console.WriteLine(count);
                    return;
                }
            }
        }
    }
}