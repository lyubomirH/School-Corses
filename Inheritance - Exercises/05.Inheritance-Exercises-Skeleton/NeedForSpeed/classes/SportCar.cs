using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed.classes
{
    public class SportCar : Vehicle
    {
        private const double SportCarFuelConsumption = 10;

        public SportCar(int horsePower, double fuel)
            : base(horsePower, fuel) 
        { 
        }

        public override double FuelConsumption => SportCarFuelConsumption;
    }
}
