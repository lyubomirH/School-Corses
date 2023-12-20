namespace Worms_Holes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] wormInput = Console.ReadLine().Split(' ');
            List<int> worms = wormInput.Select(int.Parse).ToList();

            string[] holeInput = Console.ReadLine().Split(' ');
            List<int> holes = holeInput.Select(int.Parse).ToList();

            MatchWormsAndHoles(worms, holes);

        }
        static void MatchWormsAndHoles(List<int> worms, List<int> holes)
        {
            int matchesCount = 0;

            for (int i = worms.Count - 1; i >= 0 && holes.Count > 0; i--)
            {
                int currentWorm = worms[i];

                if (holes[0] == currentWorm)
                {
                    matchesCount++;
                    worms.RemoveAt(i);
                    holes.RemoveAt(0);
                }
                else
                {
                    currentWorm -= 3;
                    if (currentWorm <= 0)
                    {
                        worms.RemoveAt(i);
                    }
                    else
                    {
                        worms[i] = currentWorm;
                    }
                    holes.RemoveAt(0);
                }
            }

            Console.WriteLine($"Matches: {matchesCount}");

            if (worms.Count == 0)
            {
                if (matchesCount == holes.Count)
                {
                    Console.WriteLine("Every worm found a suitable hole!");
                }
                else
                {
                    Console.WriteLine("Worms left: none");
                }
            }
            else
            {
                Console.WriteLine($"Worms left: {string.Join(", ", worms)}");
            }

            if (holes.Count == 0)
            {
                Console.WriteLine("Holes left: none");
            }
            else
            {
                Console.WriteLine($"Holes left: {string.Join(", ", holes)}");
            }
        }
    }
}