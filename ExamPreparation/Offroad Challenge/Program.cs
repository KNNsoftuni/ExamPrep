namespace Offroad_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> fuelStart = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Queue<int> consumptionIndexStart = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int[] fuelNeededStart = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<string> reachedAltitudes = new List<string>();

            bool reachedTop = true;

            for (int i = 1; i <= fuelNeededStart.Length; i++)
            {
                int fuel = fuelStart.Pop();
                int index = consumptionIndexStart.Dequeue();
                int neededFuel = fuelNeededStart[i - 1];

                if ((fuel - index) >= neededFuel)
                {
                    reachedAltitudes.Add($"Altitude {i}");
                    Console.WriteLine(string.Format($"John has reached: Altitude {i}"));
                }
                else
                {
                    reachedTop = false;
                    Console.WriteLine(string.Format($"John did not reach: Altitude {i}"));
                    break;
                }
            }

            if (reachedTop == false)
            {
                Console.WriteLine("John failed to reach the top.");

                if (reachedAltitudes.Count == 0)
                {
                    Console.WriteLine("John didn't reach any altitude.");
                }
                else
                {
                    Console.WriteLine("Reached altitudes: " + string.Join(", ", reachedAltitudes));
                }
            }
            else
            {
                Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
            }
        }
    }
}