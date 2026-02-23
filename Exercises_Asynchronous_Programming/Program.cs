namespace Exercises_Asynchronous_Programming
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Chronometer chronometer = new Chronometer();
            string command = string.Empty;

            while ((command = Console.ReadLine().ToLower()) != "exit")
            {
                switch (command)
                {
                    case "start":
                        await Task.Run(() => chronometer.Start());
                        break;
                    case "stop":
                        chronometer.Stop();
                        break;
                    case "lap":
                        string lapTime = chronometer.Lap();
                        Console.WriteLine(lapTime);
                        break;
                    case "laps":
                        if (chronometer.Laps.Count == 0)
                        {
                            Console.WriteLine("Laps: no laps");
                        }
                        else
                        {
                            Console.WriteLine("Laps:");
                            for (int i = 0; i < chronometer.Laps.Count; i++)
                            {
                                Console.WriteLine($"{i}. {chronometer.Laps[i]}");
                            }
                        }
                        break;
                    case "time":
                        Console.WriteLine(chronometer.GetTime);
                        break;
                    case "reset":
                        chronometer.Reset();
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }

            chronometer.Stop();
        }
    }
}
