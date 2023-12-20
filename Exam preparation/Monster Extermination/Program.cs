using System.Linq.Expressions;

namespace Monster_Extermination
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] armorInput = Console.ReadLine().Split(',');
            List<int> armorValues = armorInput.Select(int.Parse).ToList();

            string[] strikeInput = Console.ReadLine().Split(',');
            List<int> strikeValues = strikeInput.Select(int.Parse).ToList();

            SimulateBattle(armorValues, strikeValues);
        }
        static void SimulateBattle(List<int> armorValues, List<int> strikeValues)
        {
            int monstersKilled = 0;

            while (armorValues.Any() && strikeValues.Any())
            {
                int armor = armorValues[0];
                int strike = strikeValues.Last();

                if (strike >= armor)
                {
                    monstersKilled++;
                    strikeValues.RemoveAt(strikeValues.Count - 1);
                    int remainingStrike = strike - armor;
                    if (remainingStrike > 0)
                    {
                        if (strikeValues.Any())
                            strikeValues[strikeValues.Count - 1] += remainingStrike;
                        else
                            strikeValues.Add(remainingStrike);
                    }
                    armorValues.RemoveAt(0);
                }
                else
                {
                    armorValues.Add(armor - strike);
                    strikeValues.RemoveAt(strikeValues.Count - 1);
                }
            }

            if (!armorValues.Any())
                Console.WriteLine("All monsters have been killed!");
            else
                Console.WriteLine("The soldier has been defeated.");

            Console.WriteLine($"Total monsters killed: {monstersKilled}");
        }
    }

}
