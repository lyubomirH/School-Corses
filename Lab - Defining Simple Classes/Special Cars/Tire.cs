using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Cars
{
    public class TireSet
    {
        public List<(int Year, double Pressure)> Tires { get; set; }

        public TireSet(List<(int Year, double Pressure)> tires)
        {
             Tires = tires;
        }

        public double GetPressureSum()
        {
            return Tires.Sum(t => t.Pressure);
        }
    }
}
