namespace Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToArray();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                switch (command)                            
                {                                            
                    case "add": 
                        numbers = ArithmeticFunction(numbers, number => number + 1); 
                        break;
                    case "multiply": 
                        numbers = ArithmeticFunction(numbers, number => number * 2); 
                        break;
                    case "subtract": 
                        numbers = ArithmeticFunction(numbers, number => number - 1); 
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", numbers)); 
                        break;
                    default: 
                        break;
                }
            }
        }                                                                             
        public static int[] ArithmeticFunction(int[] collection, Func<int, int> function)
        {
            return collection.Select(number => function(number)).ToArray();
        }
    }
}