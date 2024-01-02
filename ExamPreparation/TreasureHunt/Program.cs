namespace TreasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chest = Console.ReadLine().Split("|").ToList();
            string command = "";

            while (command != "Yohoho!")
            {
                command = Console.ReadLine();

                string[] items = command.Split();
                string action = items[0];

                switch (action)
                {
                    case "Loot":
                        for (int i = 1; i < items.Length; i++)
                        {
                            string item = items[i];
                            if (!chest.Contains(item))
                            {
                                chest.Insert(0, item);
                            }
                        }
                        break;

                    case "Drop":
                        int index = int.Parse(items[1]);
                        if (index >= 0 && index < chest.Count)
                        {
                            string droppedItem = chest[index];
                            chest.RemoveAt(index);
                            chest.Add(droppedItem);
                        }
                        break;

                    case "Steal":
                        int count = Math.Min(int.Parse(items[1]), chest.Count);

                        List<string> stolenItems = chest.TakeLast(count).ToList();

                        chest.RemoveRange(chest.Count - count, count);

                        Console.WriteLine(string.Join(", ", stolenItems));
                        break;
                }
            }

            double averageGain = chest.Sum(item => item.Length) / (double)chest.Count;

            if (chest.Count > 0)
            {
                Console.WriteLine($"Average treasure gain: {averageGain:F2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}