namespace Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Nums();
           for (int i = 0; i < nums.Count; i++) 
           {
                if (nums[i] < 0) 
                { 
                    nums.RemoveAt(i--); 
                }

           }
            nums.Reverse();
            if (nums.Count == 0) 
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", nums));
            }
        }
        static List<int> Nums()
        {
                 return Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
        }
    }
}