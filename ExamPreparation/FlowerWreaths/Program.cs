namespace FlowerWreaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lilies = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int[] roses = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int flowerWreaths = wreaths(lilies, roses);

            if (flowerWreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {flowerWreaths} wreaths!");
            }
            else
            {
                int wreathsNeeded = 5 - flowerWreaths;
                Console.WriteLine($"You didn't make it, you need {wreathsNeeded} wreaths more!");
            }
        }

        static int wreaths(int[] lilies, int[] roses)
        {
            int flowerWreaths = 0;
            int flowers = 0;

            for (int i = lilies.Length - 1; i >= 0;)
            {
                for (int j = 0; j < roses.Length;) 
                {
                    int sum = lilies[i] + roses[j];

                    if (sum == 15)
                    {
                        flowerWreaths++;
                        i--;
                        j++;
                    }
                    else if (sum > 15)
                    {
                        lilies[i] -= 2;
                    }
                    else
                    {
                        flowers += sum;
                        i--;
                        j++;
                    }
                }
            }

            flowerWreaths += flowers / 15;

            return (flowerWreaths);
        }
    }
}