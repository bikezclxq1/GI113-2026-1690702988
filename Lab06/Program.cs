/*
* Student ID : 1690702988
* Name       : Lab06
* Section    : 129C
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // //int lives = 1;

            // //if (lives <= 0) // ใส่เงื่อนไขที่ต้องการเช็ค ค่าที่ได้ต้องเป็น true หรือ false
            // {
            //     // โค้ดจะรันก็ต่อเมื่อ if เป็น true เท่านั้น  
            //     //Console.WriteLine("Game Over");
            // }
            //// else
            // {
            //     //Console.WriteLine("Keep Fighting");
            // }

            // // ถ้า if ทำงานเสร็จแล้ว หรือ เป็น false จะมาทำงานต่อบรนทัดด้านนอกทันที
            // //Console.WriteLine("Continue Code");

            // int level = 10;

            // // เมื่อใช้เงื่อนไขหลายเคส ให้เช็ค เลขมาก --> เลขน้อยเสมอ
            // if (level >= 10) // เงี่ยนไข 1
            // {
            //     Console.WriteLine("Boss floor unlocked.");
            // }


            // else if (level <= 5) // เงี่ยนไข 2 ถ้าไม่ตรงเงื่อนไขที่ 1 จะมาดูเงื่อนไขที่ 2
            // {
            //     Console.WriteLine("The door opens.");
            // }


            // else // เมื่อไม่ตรงซักเงื่อนไข
            // {
            //     Console.WriteLine("The door stays shut.");
            // }



            // bool isPosioned = true;

            // if (isPosioned == true) // เช็คว่าเป็นจริงไหม ?
            // {
            //     Console.WriteLine("You Died");
            // }
            // else if (isPosioned == false) // เช็คว่าเป็นเท็จไหม ?
            // {
            //     Console.WriteLine("You Lives.");
            // }


            // //int lives = 10;

            // bool hasKey = true;

            // Console.Write("Your level (1-99): ");
            // bool inputValid = int.TryParse(Console.ReadLine(), out level);

            // if (!inputValid || level < 1 || level > 99) // เงื่อนไขที่ถือว่าข้อมูลผิด
            // {
            //     Console.WriteLine("Invalid Level"); // เตือนเมื่อ User ใส่้ข้อมูลผิด
            // }

            // // เมื่อใช้เงื่อนไขหลายเคส ให้เช็ค เลขมาก --> เลขน้อยเสมอ
            // else if (level >= 10 && hasKey) // เงื่อนไข 1 มากกว่าหรือเท่ากับ 10 และต้องมีกุญแจด้วย
            // {
            //     Console.WriteLine("Boss floor unlocked.");
            // }
            // else if (level >= 5) // เงื่อนไข 2 ถ้าไม่ตรงเงื่อนไขที่ 1 จะมาดูเงื่อนไขที่ 2
            // {
            //     if (hasKey == true) // ถ้ามี key
            //     {
            //         Console.WriteLine("The door opens.");
            //     }
            //     else // เมื่อตรงข้ามไม่มีกุญแจ
            //     {
            //         Console.WriteLine("Locked, Find a key.");
            //     }
            // }
            // else
            // {
            //     Console.WriteLine("The door stays shut.");
            // }



            int AckermanHp = 200;
            int AckermanSpeed = 25;
            int TitanHp = 200;
            int AckermanAttack = 100;
            int SpeedboostPotion = 10;
            int KnifeDoubleDamage = 200;

            Console.WriteLine("");
            Console.WriteLine("+==================================+");
            Console.WriteLine($"|       + ATTACK ON TITAN +        |");
            Console.WriteLine($"|      The victry Of Humanity      | ");
            Console.WriteLine("+==================================+");

            Console.WriteLine("  ");

            Console.WriteLine("+=================================+");
            Console.WriteLine("STEP 1 : ATTACK TITAN ");
            Console.WriteLine("STEP 2 : DRINK SPEEDBOOST POTION  ");
            Console.WriteLine("STEP 3 : USE KNIFE DOUBLE DAMAGE  ");
            Console.WriteLine("+=================================+");

            Console.WriteLine("  ");

            Console.WriteLine("Ackerman --> Choose your step (1-3): ");
            bool UserInput = int.TryParse(Console.ReadLine(), out int step);

            if (!UserInput || step < 1 || step > 3)
            {
                if (step < 1 || step > 3)
                {
                    Console.WriteLine("Ackerman choose your step 1-3");
                }
                else
                {
                    Console.WriteLine("Invalid Input, pls try again, choose your step 1-3 only ^_^");
                }
            }
            else if (step == 1)
            {
                TitanHp -= AckermanAttack;
                if (TitanHp <= 0)
                {
                    Console.WriteLine("Titan is defeated!");
                }
                else
                {
                    Console.WriteLine($"Ackerman attack titan, titan hp left {TitanHp}");
                }
            }
            else if (step == 2)
            {
                AckermanSpeed += SpeedboostPotion;
                Console.WriteLine($"Ackerman drink speedboost potion, Ackerman Speed boost to {AckermanSpeed}");
            }
            else if (step == 3)
            {
                TitanHp -= KnifeDoubleDamage;
                Console.WriteLine($"Ackerman attack damage X2 , titan is defeated!");
            }
        }
    }
}
