using System.Drawing;

namespace Rectangle_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int widht = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string color = Console.ReadLine();

            Rectangle firstRect = new Rectangle(widht, height, color);

            Console.WriteLine($"Rect({firstRect.Widht}, {firstRect.Height}, {firstRect.Color}) has area {firstRect.CalcArea()}.");
        }
    }
    public class Rectangle
    {
        private int widht;
        private int height;
        private string color;

        public int Widht
        {
            get { return this.widht; }
            set
            {
                if (value > 0)
                {
                    this.widht = value;
                }
                else
                {
                    this.widht = 1;
                }
            }
        }
        public int Height
        {
            get { return this.height; }
            set
            {
                if (value > 0)
                {
                    this.height = value;
                }
                else
                {
                    this.height = 1;
                }
            }
        }
        public string Color
        {
            get { return this.color; }
            set
            {
                if (value != string.Empty)
                {
                    this.color = value;
                }
                else
                {
                    this.color = "colorless";
                }
            }
        }
        public Rectangle(int widht, int height, string color)
        {
            this.Widht = widht;
            this.Height = height;
            this.Color = color;
        }

        public int CalcArea()
        {
            return this.Widht * this.Height;
        }
    }
}