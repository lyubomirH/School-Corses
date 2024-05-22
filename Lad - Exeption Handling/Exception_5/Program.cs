namespace Exception_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exceptionCount = 0;
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (exceptionCount < 3)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split();

                try
                {
                    string command = parts[0];

                    if (command == "Replace")
                    {
                        int index = int.Parse(parts[1]);
                        int element = int.Parse(parts[2]);
                        if (index < 0 || index >= numbers.Count)
                        {
                            throw new IndexOutOfRangeException();
                        }
                        numbers[index] = element;
                    }
                    else if (command == "Print")
                    {
                        int startIndex = int.Parse(parts[1]);
                        int endIndex = int.Parse(parts[2]);
                        if (startIndex < 0 || endIndex >= numbers.Count || startIndex > endIndex)
                        {
                            throw new IndexOutOfRangeException();
                        }
                        Console.WriteLine(string.Join(", ", numbers.GetRange(startIndex, endIndex - startIndex + 1)));
                    }
                    else if (command == "Show")
                    {
                        int index = int.Parse(parts[1]);
                        if (index < 0 || index >= numbers.Count)
                        {
                            throw new IndexOutOfRangeException();
                        }
                        Console.WriteLine(numbers[index]);
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    exceptionCount++;
                    Console.WriteLine("The index does not exist!");
                }
                catch (FormatException)
                {
                    exceptionCount++;
                    Console.WriteLine("The variable is not in the correct format!");
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
