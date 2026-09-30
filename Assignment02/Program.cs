/*
* Student ID : 1690702988
* Name       : Lab07
* Section    : 129C
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const double smeltRate = 0.5000;
            const double salvageRate = 0.7000;
            const double maxBatch = 500;
            const double stopLowest = 0;


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("==================================");
            Console.Write("=== ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" # Welcome to the Forge  # ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("=== ");
            Console.WriteLine(" ");

            Console.WriteLine("==================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Iron smelting: 0.50 / savage 0.70");
            Console.WriteLine(" Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine(" Key 'B' for Savage (Ingot -> Bar)");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Choose S OR B : ");


            bool ore = char.TryParse(Console.ReadLine(), out char araideewa);
            if (araideewa == 'S')
            {
                if (araideewa == 'S')
                {
                    Console.WriteLine("How much would you like.");
                    double.TryParse(Console.ReadLine(), out double ironAmount);
                    if (ironAmount <= maxBatch && ironAmount >= stopLowest)
                    {
                        double ironjung = ironAmount * smeltRate;
                        Console.WriteLine($"You have received {ironjung:f2} Iron bar");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Number, Try again");
                    }
                }
            }
            else if (araideewa == 'B')
            {
                if (araideewa == 'B')
                {
                    Console.WriteLine("How much would you like.");
                    double.TryParse(Console.ReadLine(), out double goldAmount);
                    if (goldAmount <= maxBatch && goldAmount >= stopLowest)
                    {
                        double goldjing = goldAmount / salvageRate;
                        Console.WriteLine($"You have received {goldjing:f2} Gold bar");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Number, Try again");
                    }
                }

            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
    }
}