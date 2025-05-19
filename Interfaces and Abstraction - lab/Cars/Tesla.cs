using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public string Model { get; set; }
        public string Coulor { get; set; }
        public int Battery { get ; set; }

        public Tesla(string model, string coulor, int battery)
        {
            Model = model;
            Coulor = coulor;
            Battery = battery;
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
            return $"{Coulor} Tesla {Model} with {Battery} Batteries";
        }
    }
}
