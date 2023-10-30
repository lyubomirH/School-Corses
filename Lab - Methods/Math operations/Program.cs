using System.Security;

namespace Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double firstNum = double.Parse(Console.ReadLine());
           char Operator = char.Parse(Console.ReadLine());
           double secondNum = double.Parse(Console.ReadLine());
            Calculations(firstNum, secondNum, Operator);
        }
        static void Calculations(double firstNum, double secondNum, char Operator) 
            {
            double sum = 0;
                switch (Operator)
                {
                    case '+':
                    sum = firstNum + secondNum;
                        break;
                    
                    case '-':
                    sum = firstNum - secondNum;
                    break;
                    case '*':
                    sum = firstNum * secondNum;
                    break;
                    case '/':
                    sum = firstNum / secondNum;
                    break;
                }
            Console.WriteLine(sum);
        }
        
    }
}