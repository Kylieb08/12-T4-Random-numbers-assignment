namespace _12_T4_Random_numbers_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            //Variables
            int min, max, die1, die2, decimalPlace;
            double randomDouble, minDbl, maxDbl;



            ////Random Integers
            //Console.WriteLine("Random Integers");
            //Console.WriteLine();
            //Console.WriteLine("Please enter a minimum value");
            //while (!int.TryParse(Console.ReadLine(), out min))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Please enter a maximum value");
            //while (!int.TryParse(Console.ReadLine(), out max))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}   
            //while (max < min)
            //{
            //    Console.WriteLine("Maximum must be greater than or equal to minimum. Please enter a valid maximum value.");
            //    while (!int.TryParse(Console.ReadLine(), out max))
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    }
            //}

            //for (int i = 0; i <= 5; i++)
            //{
            //    int randomInt = generator.Next(min, max + 1);
            //    Console.WriteLine($"Random Integer {i + 1}: {randomInt}");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Press ENTER to continue");
            //Console.ReadLine();
            //Console.Clear();

            ////Dice Roller
            //Console.WriteLine("Dice Roller");
            //die1 = generator.Next(1, 7);
            //die2 = generator.Next(1, 7);
            //Console.WriteLine($"You rolled a {die1} and a {die2} for a total of {die1 + die2}");
            //Console.WriteLine();
            //Console.WriteLine("Press ENTER to continue");
            //Console.ReadLine();
            //Console.Clear();

            ////Random Decimals
            //Console.WriteLine("Random Decimals");
            //Console.WriteLine();
            //for (int i = 0; i <= 2; i++)
            //{
            //    randomDouble = generator.NextDouble() * ((max + 0.001) - min) + min;
            //    randomDouble = Math.Round(randomDouble, 2);
            //    Console.WriteLine($"{randomDouble}");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Press ENTER to continue");
            //Console.ReadLine();
            //Console.Clear();

            //Challenges 1 and 3
            Console.WriteLine("Enter a minimum value");
            while (!double.TryParse(Console.ReadLine(), out minDbl))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.WriteLine("Enter a maximum value");
            while (!double.TryParse(Console.ReadLine(), out maxDbl))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            while (maxDbl < minDbl)
            {
                Console.WriteLine("Maximum must be greater than or equal to minimum. Please enter a valid maximum value.");
                while (!double.TryParse(Console.ReadLine(), out maxDbl))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            Console.WriteLine("Enter the number of decimal places (0-15)");
            while (!int.TryParse(Console.ReadLine(), out decimalPlace) || decimalPlace < 0 || decimalPlace > 15)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer between 0 and 15.");
            }
            Console.WriteLine();
            for (int i = 0; i <= 2; i++)
            {
                randomDouble = generator.NextDouble() * ((maxDbl + Math.Pow(10, -decimalPlace)) - minDbl) + minDbl;
                //                                                  ^makes the dbl generator inclusive
                randomDouble = Math.Round(randomDouble, decimalPlace);
                Console.WriteLine($"{randomDouble}");
            }

            Console.WriteLine();
            Console.WriteLine("Press ENTER to exit");
        }
    }
}
