using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : IDrawable
    {
        public int Radius { get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }
        void IDrawable.Draw()
        {
            double rIn = this.Radius - 0.4;
            double rout = this.Radius + 0.4;
            for (double y = this.Radius; y >= this.Radius; --y)
            {
                for (double x = -this.Radius; x < rout; x += 0.5)
                {
                    double value = x * x + y * y;

                    if (value >= rIn * rIn && value <= rout * rout)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
