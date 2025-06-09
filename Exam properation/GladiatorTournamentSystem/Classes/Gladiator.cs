using GladiatorTournamentSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorTournamentSystem.Classes
{
    public abstract class Gladiator : Entity, IGladiator
    {
        private List<IWeapon> equipment;
        public Gladiator(int id, string name, decimal cost, double powerLeve) 
            : base(id, name, cost, powerLeve)
        {
            equipment = new List<IWeapon>();
        }

        IReadOnlyCollection<IWeapon> IGladiator.equipment {
            get
            {
                return equipment;
            }
        }
        public override decimal Cost 
        {
            get
            {
                decimal EquipmentCost = equipment.Sum(w => w.Cost) / equipment.Count;
                return EquipmentCost + base.Cost;
            }
        }
        public override double PowerLeve
        {
            get
            {
                double averageEquipmentPowerLevel = equipment.Sum(w => w.PowerLeve) / equipment.Count;
                return averageEquipmentPowerLevel + base.PowerLeve;

            }
        }
        public void AddWeapon(IWeapon equipment)
        {
            if (this.equipment.Where(w=>w.Id == equipment.Id).Count() > 0)
            { 
                throw new ArgumentException($"Weapon with Id {Id} is already added");
            }
            this.equipment.Add(equipment);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"&quot;Name: {Name} with: Power Level: {PowerLeve}. Cost: {Cost} (Id:{Id})");
            sb.AppendLine($"Weapons({equipment.Count}):");
            foreach (var weapon in equipment)
            {
                sb.AppendLine($" {weapon.ToString()}");
            }
            return sb.ToString();
        }
    }
}
