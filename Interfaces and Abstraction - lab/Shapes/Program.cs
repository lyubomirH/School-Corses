namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var countHeight = int.Parse(Console.ReadLine());
            var countWidth = int.Parse(Console.ReadLine());
            var radius = int.Parse(Console.ReadLine());
            IDrawable rect = new Rectangle(countHeight, countWidth);
            IDrawable circle = new Circle(radius);
            rect.Draw();
            circle.Draw();
        }
    }
}
