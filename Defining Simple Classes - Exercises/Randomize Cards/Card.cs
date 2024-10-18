using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Card
{
    public class Card
    {
        public string Face { get; set; }
        public string Suite { get; set; }
        public void Print()
        {
            Console.WriteLine($"{this.Face} {this.Suite}");
        }
    }
}
