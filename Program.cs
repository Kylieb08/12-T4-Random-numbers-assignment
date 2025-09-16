namespace _12_T4_Random_numbers_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            //Variables
            int min, max, die1, die2;



            //Random Integers
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
        }
    }
}
