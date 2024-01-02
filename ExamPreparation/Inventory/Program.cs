namespace Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();
            string[] command = Console.ReadLine().Split(" - ");
            string[] item = new string[2];

            while (command[0] != "Craft!")
            {

                switch (command[0])
                {
                    case "Collect":
                        if (!items.Contains(command[1]))
                        {
                            items.Add(command[1]);
                        }
                        break;

                    case "Drop":
                        items.Remove(command[1]);
                        break;

                    case "Combine Items":
                        item = command[1].Split(":");
                        if (items.Contains(item[0]))
                        {
                            items.Insert(items.FindIndex(x => x == item[0]) + 1, item[1]);
                        }
                        break;

                    case "Renew":
                        if (items.Contains(command[1]))
                        {
                            items.Remove(command[1]);
                            items.Add(command[1]);
                        }
                        break;

                }
                command = Console.ReadLine().Split(" - ");
            }

            Console.WriteLine(string.Join(", ", items));

        }
    }
}