using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorTournamentSystem.Interfaces
{
    public interface IEntity
    {
        int Id { get; }
        string Name { get; }
        decimal Cost { get; }
        double PowerLeve { get; }
    }
}
