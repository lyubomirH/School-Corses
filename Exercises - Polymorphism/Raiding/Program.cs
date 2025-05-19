using System;
using System.Collections.Generic;
using PolymorphismExercises.Raiding;

namespace PolymorphismExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                try
                {
                    BaseHero hero = HeroFactory.CreateHero(heroType, heroName);
                    heroes.Add(hero);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                }
            }

            int bossPower = int.Parse(Console.ReadLine());
            int totalPower = 0;

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
                totalPower += hero.Power;
            }

            Console.WriteLine(totalPower >= bossPower ? "Victory!" : "Defeat...");
        }
    }
}