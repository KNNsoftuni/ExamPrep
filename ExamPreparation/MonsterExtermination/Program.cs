namespace MonsterExtermination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> armor = Console.ReadLine()
                .Split(',')
                .Select(int.Parse)
                .ToList();
            List<int> impactValues = Console.ReadLine()
                .Split(',')
                .Select(int.Parse)
                .ToList();

            int monstersKilled = 0;

            while (armor.Any() && impactValues.Any())
            {
                int monsterArmor = armor.First();
                int currentStrike = impactValues.Last();

                if (currentStrike >= monsterArmor)
                {
                    armor.RemoveAt(0);
                    impactValues.RemoveAt(impactValues.Count - 1);

                    int remainingImpact = currentStrike - monsterArmor;

                    if (impactValues.Any())
                    {
                        impactValues[impactValues.Count - 1] += remainingImpact;
                    }
                }
                else
                {
                    armor[0] -= currentStrike;
                    impactValues.RemoveAt(impactValues.Count - 1);
                    armor.Add(armor[0]);
                    armor.RemoveAt(0);
                }

                monstersKilled++;
            }

            if (armor.Any())
            {
                Console.WriteLine("The soldier has been defeated.");
                Console.WriteLine($"Total monsters killed: {monstersKilled - 1}");
            }
            else
            {
                Console.WriteLine("All monsters have been killed!");
                Console.WriteLine($"Total monsters killed: {monstersKilled}");
            }
        }

    }
}