using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Salesman
{
    internal class Car
    {
        public string Model { get; }
        public Engine Engine { get; }
        public int? Weight { get; } 
        public string Color { get; }

        public Car(string model, Engine engine, int? weight = null, string color = "n/a")
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public override string ToString()
        {
            string weightStr = Weight.HasValue ? Weight.ToString() : "n/a";
            return $"{Model}:\n  {Engine}\n  Weight: {weightStr}\n  Color: {Color}";
        }
    }
}
