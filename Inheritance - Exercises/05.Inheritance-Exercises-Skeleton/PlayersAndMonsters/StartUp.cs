using PlayersAndMonsters.Classes;
using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string gameClass = Console.ReadLine();
            string username = Console.ReadLine();
            int level = int.Parse(Console.ReadLine());

            switch (gameClass)
            {
                case "Elf":
                    var elf = new Elf(username, level);
                    Console.WriteLine(elf.ToString());
                    break;
                case "BladeKnight":
                    var BladeKnight = new BladeKnight(username, level);
                    Console.WriteLine(BladeKnight.ToString());
                    break;
                case "DarkKnight":
                    var DarkKnight = new DarkKnight(username, level);
                    Console.WriteLine(DarkKnight.ToString());
                    break;
                case "DarkWizard":
                    var DarkWizard = new DarkWizard(username, level);
                    Console.WriteLine(DarkWizard.ToString());
                    break;
                case "Knight":
                    var Knight = new Knight(username, level);
                    Console.WriteLine(Knight.ToString());
                    break;
                case "MuseElf":
                    var MuseElf = new MuseElf(username, level);
                    Console.WriteLine(MuseElf.ToString());
                    break;
                case "SoulMaster":
                    var SoulMaster = new SoulMaster(username, level);
                    Console.WriteLine(SoulMaster.ToString());
                    break;
                case "Wizard":
                    var Wizard = new Wizard(username, level);
                    Console.WriteLine(Wizard.ToString());
                    break;
            }
        }
    }
}