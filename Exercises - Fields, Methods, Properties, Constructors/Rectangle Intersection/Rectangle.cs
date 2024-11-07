using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Intersection
{
    internal class Rectangle
    {
        public string Id { get; }
        public double Width { get; }
        public double Height { get; }
        public double X { get; }
        public double Y { get; }

        public Rectangle(string id, double width, double height, double x, double y)
        {
            Id = id;
            Width = width;
            Height = height;
            X = x;
            Y = y;
        }
        public bool Intersects(Rectangle other)
        {
            bool noOverlap = X + Width < other.X || other.X + other.Width < X ||
                             Y + Height < other.Y || other.Y + other.Height < Y;

            return !noOverlap;
        }
    }
}
