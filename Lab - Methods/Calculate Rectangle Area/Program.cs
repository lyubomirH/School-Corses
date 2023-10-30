namespace Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = RectangleArea(width, height);
            Console.WriteLine(area);
        }
        static double RectangleArea(double a, double b)
               {
                 double result = a * b;
                 return result;
               }
    }
}