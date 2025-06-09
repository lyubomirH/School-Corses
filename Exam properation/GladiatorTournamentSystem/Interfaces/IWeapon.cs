using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorTournamentSystem.Interfaces
{
    public interface IWeapon : IEntity
    {
        int Sharpness { get; }
    }
}
