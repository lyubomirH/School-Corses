namespace Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            RaisedToPower(number, power);
            
        }
        static double RaisedToPower (double number, int power)
        {
            double result = number; 
            result = Math.Pow(number, power);
            Console.WriteLine(result);
            return result;
        }
    }
}