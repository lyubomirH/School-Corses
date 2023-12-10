namespace Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputSongs = Console.ReadLine().Split(", ").ToList();
            Queue<string> songsQueue = new Queue<string>();

            foreach (string song in inputSongs)
            {
                songsQueue.Enqueue(song);
            }

            while (songsQueue.Any())
            {
                string command = Console.ReadLine();

                if (command == "Play")
                {
                    songsQueue.Dequeue();
                }
                else if (command.StartsWith("Add"))
                {
                    string songFullname = command.Substring(4);
                    if (songsQueue.Contains(songFullname))
                    {
                        Console.WriteLine($"{songFullname} is already contained! ");
                    }
                    else
                    {
                        songsQueue.Enqueue(songFullname);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine("{0}", string.Join(", ", songsQueue));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}