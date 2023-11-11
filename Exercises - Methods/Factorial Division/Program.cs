namespace Factorial_division
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            FirstFactorial(firstNum);
            SecondFactorial(secondNum);

            Console.WriteLine($"{FinalResult(firstNum, secondNum):F2}");
        }
        static double FirstFactorial(double a)
        {
            double current = 1;
            double actual = 0;

            if (a >= 1)
            {
                for (double num = a; num >= 1; num--)
                {
                    actual = num;
                    current = actual * current;
                }
            }
            return current;
        }
        static double SecondFactorial(double b)
        {
            double digit = 1;
            double value = 0;

            if (b >= 1)
            {

                for (double num = b; num >= 1; num--)
                {
                    value = num;
                    digit = value * digit;
                }
            }
            return digit;
        }
        static double FinalResult(double a, double b)
        {
            double calculation = FirstFactorial(a) / SecondFactorial(b);
            return calculation;
        }

    }
}