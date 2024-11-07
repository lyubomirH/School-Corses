using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection;
using System.Security.Cryptography;
using System;

namespace Rectangle_Intersection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split();
            int n = int.Parse(firstLine[0]);
            int m = int.Parse(firstLine[1]);

            Dictionary<string, Rectangle> rectangles = new Dictionary<string, Rectangle>();

            for (int i = 0; i < n; i++)
            {
                var rectangleInfo = Console.ReadLine().Split();
                string id = rectangleInfo[0];
                double width = double.Parse(rectangleInfo[1]);
                double height = double.Parse(rectangleInfo[2]);
                double x = double.Parse(rectangleInfo[3]);
                double y = double.Parse(rectangleInfo[4]);

                rectangles[id] = new Rectangle(id, width, height, x, y);
            }

            for (int i = 0; i < m; i++)
            {
                var pair = Console.ReadLine().Split();
                string firstId = pair[0];
                string secondId = pair[1];

                Rectangle firstRectangle = rectangles[firstId];
                Rectangle secondRectangle = rectangles[secondId];

                bool intersects = firstRectangle.Intersects(secondRectangle);
                Console.WriteLine(intersects.ToString().ToLower());
            }
        }
    }
}