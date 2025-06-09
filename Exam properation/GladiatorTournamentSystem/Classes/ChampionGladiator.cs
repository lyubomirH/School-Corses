using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorTournamentSystem.Classes
{
    public class ChampionGladiator : Gladiator
    {
        public ChampionGladiator(int id, string name, decimal cost) 
            : base(id, name, cost, 20)
        {

        }
    }
}
