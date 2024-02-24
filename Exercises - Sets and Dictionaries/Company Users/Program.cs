using System.ComponentModel;

namespace Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var IDs= new Dictionary<string, List<string>>();  

            string[] input = Console.ReadLine()
                .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "End") 
            { 
                string name = input[0];
                if(name != "End")
                {
                    string id = input[1];
                    if (!IDs.ContainsKey(name))
                    {
                        IDs.Add(name, new List<string>());
                        IDs[name].Add(id);
                    }
                    else
                    {
                        bool index = false;
                        foreach (var code in IDs[name])
                        {
                            if(code == id)
                            {
                                index = true;
                                break;
                            }
                           
                        }
                        if (index == false)
                        {
                            IDs[name].Add(id);
                        }
                    }
                }

             input = Console.ReadLine()
                .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach(var names in IDs.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{names.Key}");
                foreach(var id in names.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }

        }
    }
}