using System.ComponentModel;

namespace SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parking = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string cmd = commands[0];
                string name = commands[1];
                if(cmd == "register")
                {
                    string plate = commands[2];
                    if (parking.ContainsKey(name))
                    {
                        Console.WriteLine($"Error: alredy registerd with plate number {parking[name]}");
                    }
                    else
                    {
                        parking.Add(name, plate);
                        Console.WriteLine($"{name} registerd {plate} successfully");
                    }
                }
                else if(cmd == "unregister")
                {
                    if (parking.ContainsKey(name))
                    {
                        parking.Remove(name);
                        Console.WriteLine($"{name} unregisterd succssfully");
                    }
                    else 
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }
            foreach(var user in parking)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}