namespace Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string text = Console.ReadLine();
            for (int i = 0; i < nums.Count; i++)
            {
                int currentNumber = nums[i];
                int index = IndexSum(currentNumber);

                char currentChar = CharInText(index, text);
                Console.Write(currentChar);

                int realIndex = RealIndex(index, text);
                string newText = text.Remove(realIndex, 1);
                text = newText;
            }
            Console.WriteLine();
        }
        static int IndexSum(int Number)
        {
            int index = 0;
            while (Number > 0)
            {
                int currentNumber = Number % 10;
                index += currentNumber;
                Number /= 10;
            }
            return index;
        }
        static char CharInText(int index, string message)
        {
            int coundIndex = 0;

            for (int i = 0; i < index; i++)
            {
                coundIndex++;
                if (coundIndex == message.Length)
                {
                    coundIndex = 0;
                }
            }
            char currentChar = message[coundIndex];
            return currentChar;
        }
        static int RealIndex(int index, string message)
        {
            int countIndex = 0;
            
            
                countIndex = 0;
            for (int j = 0; j < index; j++)
            {
                countIndex++;
                if (countIndex == message.Length)
                {
                        countIndex = 0;
                }
            }
            return countIndex;
        }
    }
}