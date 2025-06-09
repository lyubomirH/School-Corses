using GladiatorTournamentSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorTournamentSystem.Classes
{
    public class Wepon : Entity, IWeapon
    {
        public Wepon(int id, string name, decimal cost, double powerLeve, int sharpness) 
            : base(id, name, cost, powerLeve)
        {
            Sharpness = sharpness;
        }

        public int Sharpness { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} with: Power Level: {PowerLeve}. Cost: {Cost} (Id: {Id})\r\nSharpness: {Sharpness}";
        }
    }
}
