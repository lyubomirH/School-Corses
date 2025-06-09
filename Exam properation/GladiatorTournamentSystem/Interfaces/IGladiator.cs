using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorTournamentSystem.Interfaces
{
    public interface IGladiator : IEntity
    {
        IReadOnlyCollection<IWeapon> equipment { get; }

        void AddWeapon(IWeapon equipment);
    }
}
