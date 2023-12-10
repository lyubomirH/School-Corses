using System.Text;

namespace Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder builder = new StringBuilder();
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] commandLine = Console.ReadLine().Split().ToArray();
                string command = commandLine[0];

                switch (command)
                {
                    case "1":
                        builder.Append(commandLine[1]);
                        stack.Push(builder.ToString());
                        break;

                    case "2":
                        int count = int.Parse(commandLine[1]);
                        builder.Remove(builder.Length - count, count);
                        stack.Push(builder.ToString());
                        break;
                    case "3":
                        int index = int.Parse(commandLine[1]);
                        Console.WriteLine(builder[index - 1]);
                        break;
                    case "4":
                        if (stack.Any())
                        {
                            stack.Pop();
                            builder = new StringBuilder();
                            builder.Append(stack.Peek());

                        }

                        break;
                }
            }
        }
    }
}