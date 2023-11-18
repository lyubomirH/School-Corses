﻿namespace List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] elements = command.Split();
                SwitchCaseElements(elements, nums);
            }
            Console.WriteLine(string.Join(" ", nums));
        }
        static void SwitchCaseElements(string[] elements,List<int> nums)
        {
            switch (elements[0])
            {
                case "Add":
                    int numberToAdd = int.Parse(elements[1]);
                    nums.Add(numberToAdd);
                    break;
                case "Remove":
                    int numberToRemove = int.Parse(elements[1]);
                    nums.Remove(numberToRemove);
                    break;
                case "RemoveAt":
                    int indexToRemove = int.Parse(elements[1]);
                    nums.RemoveAt(indexToRemove);
                    break;
                case "Insert":
                    int numberToInsert = int.Parse(elements[1]);
                    int indexToInsert = int.Parse(elements[2]);
                    nums.Insert(indexToInsert, numberToInsert);
                    break;
            }
        }
    }
}