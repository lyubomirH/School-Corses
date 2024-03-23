﻿using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string listOfName = Console.ReadLine();
                
            string pattern = @"\b([A-Z][a-z]+ [A-Z][a-z]+)";
            Regex regex = new Regex(pattern);
            MatchCollection validName = regex.Matches(listOfName);
            foreach (Match name in validName)
            {
                Console.WriteLine(name);
            }
        }
    }
}
