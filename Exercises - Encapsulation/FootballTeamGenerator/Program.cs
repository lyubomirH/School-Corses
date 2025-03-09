using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main()
    {
        Dictionary<string, Team> teams = new Dictionary<string, Team>();

        while (true)
        {
            string[] input = Console.ReadLine().Split(';');

            if (input[0] == "END") break;

            try
            {
                switch (input[0])
                {
                    case "Team":
                        teams[input[1]] = new Team(input[1]);
                        break;

                    case "Add":
                        if (!teams.ContainsKey(input[1]))
                        {
                            Console.WriteLine($"Team {input[1]} does not exist.");
                            continue;
                        }

                        string playerName = input[2];
                        int endurance = int.Parse(input[3]);
                        int sprint = int.Parse(input[4]);
                        int dribble = int.Parse(input[5]);
                        int passing = int.Parse(input[6]);
                        int shooting = int.Parse(input[7]);

                        Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                        teams[input[1]].AddPlayer(player);
                        break;

                    case "Remove":
                        if (!teams.ContainsKey(input[1]))
                        {
                            Console.WriteLine($"Team {input[1]} does not exist.");
                            continue;
                        }
                        teams[input[1]].RemovePlayer(input[2]);
                        break;

                    case "Rating":
                        if (!teams.ContainsKey(input[1]))
                        {
                            Console.WriteLine($"Team {input[1]} does not exist.");
                            continue;
                        }
                        Console.WriteLine($"{input[1]} - {teams[input[1]].Rating}");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
