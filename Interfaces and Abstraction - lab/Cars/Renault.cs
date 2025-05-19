using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Renault : ICar
    {
        public string Model { get; set; }
        public string Coulor { get; set; }
        public Renault(string model, string coulor)
        {
            Model = model;
            Coulor = coulor;
        }
        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
        public override string ToString()
        {
            return $"{Coulor} Renault {Model}";
        }
    }
}
