using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Engine_and_Tires
{
    public class Tire
    {
        public int year;
        public double pressure;

        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }

        public int Year { get; set; }
        public double Pressure { get; set; }
    }
}
