using System.Security.Cryptography.X509Certificates;

namespace Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, SortedSet<string>>();
            string[] input = Console.ReadLine().Split(" : ",StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "end")
            {
                string coursName = input[0];
                string strudensName = input[1];
                if (!courses.ContainsKey(coursName))
                {
                    courses.Add(coursName, new SortedSet<string>());
                }
                courses[coursName].Add(strudensName);
                input = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries);

            }
            foreach(var cours in courses.OrderByDescending(c => c.Value.Count).ToDictionary(x => x.Key, x => x.Value))
            {
                Console.WriteLine($"{cours.Key}: {cours.Value.Count}");
                foreach(var strudent in cours.Value)
                {
                    Console.WriteLine($"-- {strudent}");
                }
            }

        }
    }
}