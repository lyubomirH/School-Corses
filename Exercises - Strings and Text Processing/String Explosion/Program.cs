using System;
namespace String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for(int i = 0;  i <input.Length; i++)
            {
                if (input[i] == '>')
                {
                    for(int j = 0; j < input[i + 1]; j++)
                    {
                        int stranght = input[i + 1];
                        if (input[j] == '>')
                        {
                            stranght += input[j + 1];
                        }
                        else
                        {
                            input.Remove(j, stranght);
                        }
                    }
                }
            }
        }
    }
}