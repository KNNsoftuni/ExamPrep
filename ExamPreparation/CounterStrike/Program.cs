namespace CounterStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int victories = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End of battle")
                {
                    Console.WriteLine($"Won battles: {victories}. Energy left: {energy}");
                    break;
                }

                int distance = int.Parse(command);

                if (energy >= distance)
                {
                    energy -= distance;
                    victories++;

                    if (victories % 3 == 0)
                    {
                        energy += victories;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {victories} won battles and {energy} energy");
                    break;
                }

            }
        }
    }
}