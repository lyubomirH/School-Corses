using System;
using System.Reflection;
using System.Xml.Linq;

namespace List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = GetInList();
            string[] command = GetStringArray();
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Remove":
                        if (list.Contains(1) != false)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        list.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Insert":
                        if (list.Count < int.Parse(command[1]))
                        {
                            list.Insert(list.Count, int.Parse(command[1]));
                            break;
                        }
                        list.Insert(int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "Add":
                        list.Add(int.Parse(command[1]));
                        break;
                }
                if (command[0] == "Shift" && command[1] == "left")
                {
                    ShiftLeft(list, int.Parse(command[2]));
                }
                if (command[0] == "Shift" && command[1] == "right")
                {
                    ShiftRight(list, int.Parse(command[2]));
                }
                    command = GetStringArray();
            }
            Console.WriteLine(string.Join(" ", list));
        }
        static List<int> GetInList()
        {
            return Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
        }
        static string[] GetStringArray()
        {
            return Console.ReadLine()
                .Split(" ")
                .ToArray();
        }
        static List<int> ShiftLeft (List<int> list, int index)
        {
            for(int i = 0; i < index; i++)
            {
                int numOne = list[0];
                list.RemoveAt(0);
                list.Insert(list.Count, numOne);
            }
            return list;
        }
        static List<int> ShiftRight(List<int> list, int index)
        {
            for (int i = 0; i <= index; i++)
            {
                int numOne = list[list.Count-1];
                list.RemoveAt(list.Count - 1);
                list.Insert(0, numOne);
            }
            return list;
        }
    }
}