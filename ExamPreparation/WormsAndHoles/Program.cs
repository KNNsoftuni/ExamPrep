namespace WormsAndHoles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> worms = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> holes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int matches = 0;

            for (int i = worms.Count - 1; i >= 0; i--)
            {
                if (holes.Count == 0)
                {
                    break;
                }

                int currentEarthworm = worms[i];
                int currentBurrow = holes[0];

                if (currentEarthworm == currentBurrow)
                {
                    matches++;
                    worms.RemoveAt(i);
                    holes.RemoveAt(0);
                }
                else
                {
                    holes.RemoveAt(0);
                    currentEarthworm -= 3;

                    if (currentEarthworm > 0)
                    {
                        worms[i] = currentEarthworm;
                    }
                    else
                    {
                        worms.RemoveAt(i);
                    }
                }
            }

            Console.WriteLine($"Matches: {matches}");

            if (worms.Count == 0)
            {
                Console.WriteLine("Every worm found a suitable hole!");
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