namespace MuOnline
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|");
            string[] command = new string[2];
            int health = 100;
            int bitcoins = 0;

            int healAmount = 0;

            for (int i = 0; i < rooms.Length; i++)
            {

                command = rooms[i].Split();
                if (command[0] == "chest")
                {

                    bitcoins += int.Parse(command[1]);
                    Console.WriteLine($"You found {command[1]} bitcoins.");

                }
                else if (command[0] == "potion")
                {
                    healAmount = health;
                    health += int.Parse(command[1]);

                    if (health > 100)
                    {
                        health = 100;
                    }

                    healAmount = -1 * (healAmount - health);

                    Console.WriteLine($"You healAmount for {healAmount} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else
                {

                    if (int.Parse(command[1]) >= health)
                    {
                        Console.WriteLine($"You died! Killed by {command[0]}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        break;
                    }
                    else
                    {
                        health -= int.Parse(command[1]);
                        Console.WriteLine($"You slayed {command[0]}.");
                    }

                }
                if (i == rooms.Length - 1)
                {
                    Console.WriteLine("You've made it!");
                    Console.WriteLine($"Bitcoins: {bitcoins}");
                    Console.WriteLine($"Health: {health}");

                }
            }
        }
    }
}