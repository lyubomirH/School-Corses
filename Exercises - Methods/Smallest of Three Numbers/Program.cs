using System;

namespace Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbreOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThre = int.Parse(Console.ReadLine());

            CmaperNumber( numbreOne, numberTwo, numberThre);
        }
        static void CmaperNumber(int numberOne, int numberTwo, int numberThre)
        {
            int numO = 0;
            int numT = 0;
            int input = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (i == 1)
                    {
                        numO = numberOne;
                        if (j == 1)
                        {
                            numT = numberTwo;
                            if (numO == numT)
                            {
                                input = numO;
                            }
                            if (numO > numT)
                            {
                                input = numO;
                            }
                        }
                        if (j == 2)
                        {
                            numT = numberTwo;
                            if (numO == numT)
                            {
                                input = numO;
                            }
                            if (numO > numT)
                            {
                                input = numO;
                            }
                        }
                        if (j == 3)
                        {
                            numT = numberTwo;
                            if (numO == numT)
                            {
                                input = numO;
                            }
                            if (numO > numT)
                            {
                                input = numO;
                            }
                        }

                    }
                    if (i == 2)
                    {
                        numO = numberTwo;
                        if (j == 1)
                        {
                            numT = numberTwo;
                            if (numO == numT)
                            {
                                input = numO;
                            }
                            if (numO > numT)
                            {
                                input = numO;
                            }
                        }
                        if (j == 2)
                        {
                            numT = numberTwo;
                            if (numO == numT)
                            {
                                input = numO;
                            }
                            if (numO > numT)
                            {
                                input = numO;
                            }
                        }
                        if (j == 3)
                        {
                            numT = numberTwo;
                            if (numO == numT)
                            {
                                input = numO;
                            }
                            if (numO > numT)
                            {
                                input = numO;
                            }
                        }

                    }
                    if (i == 3)
                    {
                        numO = numbere;
                        if (j == 1)
                        {
                            numT = numberTwo;
                            if (numO == numT)
                            {
                                input = numO;
                            }
                            if (numO > numT)
                            {
                                input = numO;
                            }
                        }
                        if (j == 2)
                        {
                            numT = numberTwo;
                            if (numO == numT)
                            {
                                input = numO;
                            }
                            if (numO > numT)
                            {
                                input = numO;
                            }
                        }
                        if (j == 3)
                        {
                            numT = numberTwo;
                            if (numO == numT)
                            {
                                input = numO;
                            }
                            if (numO > numT)
                            {
                                input = numO;
                            }
                        }

                    }
                }
                
            }
            Console.WriteLine(input );
        }
    }
}