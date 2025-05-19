namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> numbersToCall = Console.ReadLine().Split(" ").ToList();
            List<string> sitsToBrawls = Console.ReadLine().Split(" ").ToList();
            foreach (string number in numbersToCall) 
            {
                if(number.Length == 10) 
                { 
                    //SmartPhone
                }
                else if (number.Length >= 7 && number.Length <= 9)
                {
                    //StationatyPhone
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
        }
    }
}
