namespace _12_T4_Random_numbers_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            //Variables
            int min, max, die1, die2;
            double randomDouble;



            //Random Integers
            Console.WriteLine("Random Integers");
            Console.WriteLine();
            Console.WriteLine("Please enter a minimum value");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please enter a maximum value");
            max = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 5; i++)
            {
                int randomInt = generator.Next(min, max + 1);
                Console.WriteLine($"Random Integer {i + 1}: {randomInt}");
            }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();

            //Dice Roller
            Console.WriteLine("Dice Roller");
            die1 = generator.Next(1, 7);
            die2 = generator.Next(1, 7);
            Console.WriteLine($"You rolled a {die1} and a {die2} for a total of {die1 + die2}");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();

            //Random Decimals
            Console.WriteLine("Random Decimals");
            Console.WriteLine();
            for (int i = 0; i <= 2; i++)
            {
                randomDouble = generator.NextDouble() * ((max + 0.001) - min) + min;
                randomDouble = Math.Round(randomDouble, 2);
                Console.WriteLine($"{randomDouble}");
            }
        }
    }
}
