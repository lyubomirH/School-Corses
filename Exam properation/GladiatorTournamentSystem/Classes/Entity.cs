using GladiatorTournamentSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorTournamentSystem.Classes
{
    public abstract class Entity : IEntity
    {
        private int id;

        public Entity(int id, string name, decimal cost, double powerLeve)
        {
            Id = id;
            Name = name;
            Cost = cost;
            PowerLeve = powerLeve;

        }
        public int Id 
        {
            get { return id; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The Id is not allowed to be zero or less.");
                }
                id = value;
            }
        }

        public string Name { get; set; }

        public virtual decimal Cost { get; set; }

        public virtual double PowerLeve { get; set; }

        public override string ToString()
        {
            return $"Power Level: {PowerLeve}. Cost: {Cost}: (Id: {Id})";
        }
    }
}
