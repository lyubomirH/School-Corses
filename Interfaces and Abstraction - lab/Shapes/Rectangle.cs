using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }
        void IDrawable.Draw()
        {
            for(int i = 0; i < Height; i++)
            {
                Console.WriteLine(new string('*', Width));
            }
            Console.WriteLine();
        }
    }
}
