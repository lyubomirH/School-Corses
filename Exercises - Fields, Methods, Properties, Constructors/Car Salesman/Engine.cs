using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Salesman
{
    internal class Engine
    {
        public string Model { get; }
        public int Power { get; }
        public int? Displacement { get; }
        public string Efficiency { get; }

        public Engine(string model, int power, int? displacement = null, string efficiency = "n/a")
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public override string ToString()
        {
            string displacementStr = Displacement.HasValue ? Displacement.ToString() : "n/a";
            return $"{Model}:\n  Power: {Power}\n  Displacement: {displacementStr}\n  Efficiency: {Efficiency}";
        }
    }
}
