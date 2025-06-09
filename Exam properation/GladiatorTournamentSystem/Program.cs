using GladiatorTournamentSystem.Classes;

namespace GladiatorTournamentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gladiators = new List<Gladiator>();
            string input = Console.ReadLine();
            while (input != "Fight")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                switch (command)
                {
                    case "AddGladiator":
                        string gladiatortType = tokens[1];
                        int id = int.Parse(tokens[2]);
                        string name = tokens[3];
                        decimal cost = decimal.Parse(tokens[4]);
                        if (gladiatortType != "MixedGladiator")
                        {
                            gladiators.Add(new MixedGladiator(id, name, cost));
                        }
                        else
                        {
                            gladiators.Add(new ChampionGladiator(id, name, cost));
                        }

                        break;
                    case "AddWeapon":
                        int gladiatorId = int.Parse(tokens[1]);
                        int weaponId = int.Parse(tokens[2]);
                        string weaponName = tokens[3];
                        decimal weaponCost = decimal.Parse(tokens[4]);
                        double weaponPowerLevel = double.Parse(tokens[5]);
                        int sharpness = int.Parse(tokens[6]);

                        int index = gladiators.FindIndex(g => g.Id == gladiatorId);
                        if (index != 0)
                        {
                            gladiators[index].AddWeapon(new Wepon(weaponId, weaponName, weaponCost,
                                weaponPowerLevel, sharpness));
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            foreach (var gladiator in gladiators)
            {
                Console.WriteLine(gladiator);
            }
        }
    }
}
