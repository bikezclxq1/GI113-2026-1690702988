/*
 * Student ID : 1690702988
 * Name       : Lab02
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is boss: {isBoss}");
           

            Console.WriteLine();
            // คำนวนเปอร์เซ็น
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}") ;
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damages!");
            Console.WriteLine() ;
            // ลด HP 60 หน่วย
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("==== BOSS STATUS: AFTER DAMAGE ====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");



            // Part B
            Console.WriteLine();
            Console.WriteLine(" ## PLAYER 1 : EREN ## ");
            string player1 = "EREN";
            char rank1 = 'S';
            int maxHp1 = 100;
            float damage1 = 35.00f;
            double speed1 = 35;
            bool isHandsome1 = true;
            Console.WriteLine($"Name: {player1}");
            Console.WriteLine($"Rank: {rank1}");
            Console.WriteLine($"Hp: {maxHp1}");
            Console.WriteLine($"Damage: {damage1}");
            Console.WriteLine($"Speed : {speed1}");
            Console.WriteLine($"Handsome: {isHandsome1}");

            Console.WriteLine(" ## PLAYER 2 : LEVI ## ");
            string player2 = "Levi";
            char rank2 = 'S';
            int maxHp2 = 100;
            float damage2 = 42.00f;
            double speed2 = 42;
            bool isHandsome2 = true;
            Console.WriteLine($"Name: {player2}");
            Console.WriteLine($"Rank: {rank2}");
            Console.WriteLine($"Hp: {maxHp2}");
            Console.WriteLine($"Damage: {damage2}");
            Console.WriteLine($"Speed : {speed2}");
            Console.WriteLine($"Handsome: {isHandsome2}");

            Console.WriteLine(" ## PLAYER 3 : ARMIN ## ");
            string player3 = "Armin";
            char rank3 = 'S';
            int maxHp3 = 100;
            float damage3 = 30.00f;
            double speed3 = 30;
            bool isHandsome3 = true;
            Console.WriteLine($"Name: {player3}");
            Console.WriteLine($"Rank: {rank3}");
            Console.WriteLine($"Hp: {maxHp3}");
            Console.WriteLine($"Damage: {damage3}");
            Console.WriteLine($"Speed : {speed3}");
            Console.WriteLine($"Handsome: {isHandsome3}");

            Console.WriteLine(" ## PLAYER 4 : MIKASA ## ");
            string player4 = "Mikasa";
            char rank4 = 'S';
            int maxHp4 = 100;
            float damage4 = 40.00f;
            double speed4 = 40;
            bool isHandsome4 = false;
            Console.WriteLine($"Name: {player4}");
            Console.WriteLine($"Rank: {rank4}");
            Console.WriteLine($"Hp: {maxHp4}");
            Console.WriteLine($"Damage: {damage4}");
            Console.WriteLine($"Speed : {speed4}");
            Console.WriteLine($"Handsome: {isHandsome4}");









        }
    }
}
