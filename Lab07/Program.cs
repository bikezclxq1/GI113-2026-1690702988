/*
* Student ID : 1690702988
* Name       : Lab07
* Section    : 129C
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/

namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Plan A

            const int MonsterHp = 10;

            Console.Write("Monster Defense: ");
            int.TryParse(Console.ReadLine(), out int monsterDefense);
            Console.WriteLine($"A Slime appears! HP {MonsterHp}, DEF {monsterDefense}");

            Console.WriteLine("=== BATTLE MENU ===");
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Fire Magic");
            Console.WriteLine("3) Defend");
            Console.WriteLine("4) Run");
            Console.Write("Choose (1-4): ");
            int.TryParse(Console.ReadLine(), out int command);

            switch (command)
            {
                case 1:
                    Console.WriteLine("Hero swings the sword!");
                    break;
                case 2:
                    Console.WriteLine("Hero casts Fire!");
                    break;
                case 3:
                    Console.WriteLine("Hero raises the shield.");
                    break;
                case 4:
                    Console.WriteLine("Hero looks for a way out...");
                    break;
                default:
                    Console.WriteLine("Hero hesitates. Invalid command!");
                    break;

            }

            int power = command switch
            {
                1 => 12,
                2 => 18,
                _ => 0
            };
            int damage = Math.Max(0, power - monsterDefense);
            Console.WriteLine($"Damage: {damage}");

            string rating = damage switch
            {
                >= 12 => "Critical hit!",
                >= 5 => "Solid hit.",
                > 0 => "Scratch.",
                _ => "No damage."
            };
            Console.WriteLine($"Rating: {rating}");

            string monsterStatus = damage >= MonsterHp ? "DEFEATED" : "still standing";
            Console.WriteLine($"Slime: {monsterStatus}");

            Console.Write("Really run away? (y/n): ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "y":
                case "Y":
                    Console.WriteLine("You escaped!");
                    break;
                case "n":
                case "N":
                    Console.WriteLine("You stay and fight.");
                    break;
                default:
                    Console.WriteLine("Please type y or n.");
                    break;
            }
            Console.WriteLine();








            // Plan B
            Console.ForegroundColor = ConsoleColor.White;

            const int MonsterHp2 = 200;

            Console.Write("Monster Defense: ");
            int.TryParse(Console.ReadLine(), out int monsterDefense2);
            Console.WriteLine($"A Slime appears! HP {MonsterHp2}, DEF {monsterDefense2}");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=== BATTLE MENU ===");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Fire Magic");
            Console.WriteLine("3) Defend");
            Console.WriteLine("4) Run");
            Console.WriteLine("5) Invisible");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Choose (1-5): ");
            Console.ForegroundColor = ConsoleColor.White;
            int.TryParse(Console.ReadLine(), out int command2);


            switch (command2)
            {
                case 1:
                    Console.WriteLine("Hero swings the sword!");
                    break;
                case 2:
                    Console.WriteLine("Hero casts Fire!");
                    break;
                case 3:
                    Console.WriteLine("Hero raises the shield.");
                    break;
                case 4:
                    Console.WriteLine("Hero looks for a way out...");
                    break;
                case 5:
                    Console.WriteLine("Hero use invisible skill.");
                    break;
                default:
                    Console.WriteLine("Hero hesitates. Invalid command!");
                    break;

            }


            int power2 = command2 switch
            {
                1 => 12,
                2 => 18,
                5 => 0,
                _ => 0
            };
            int damage2 = Math.Max(0, power2 - monsterDefense2);
            Console.WriteLine($"Damage: {damage2}");

            string rating2 = damage2 switch
            {
                >= 12 => "Critical hit!",
                >= 5 => "Solid hit.",
                > 0 => "Scratch.",
                _ => "No damage."
            };
            Console.WriteLine($"Rating: {rating2}");

            string monsterStatus2 = damage2 >= MonsterHp2 ? "DEFEATED" : "still standing";
            Console.WriteLine($"Slime: {monsterStatus2}");

            Console.Write("Really run away? (y/n): ");
            string answer2 = Console.ReadLine();

            switch (answer2)
            {
                case "y":
                case "Y":
                    Console.WriteLine("You escaped!");
                    break;
                case "n":
                case "N":
                    Console.WriteLine("You stay and fight.");
                    break;
                default:
                    Console.WriteLine("Please type y or n.");
                    break;
            }
        }
    }
    }
