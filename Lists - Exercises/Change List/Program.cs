using System;
using System.Diagnostics;

namespace Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = GetInList();
            string[] command = GetStringArray();
            while (command[0]?.ToLower() != "end")
            {
                switch (command[0])
                {
                    case "Delete":
                        DeleteElements(int.Parse(command[1]), list);

                        break;
                    case "Insert":
                        list.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
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

        static List<int> DeleteElements(int index, List<int> list)
        {
            for (int  i = 0; i < list.Count; i++)
            {
                list.Remove(index);
            }
            return list;
        }
    }
}