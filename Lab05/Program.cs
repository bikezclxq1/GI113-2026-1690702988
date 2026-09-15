namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game title, Sub-title
            Console.WriteLine("====>> MY GAME DEE <<====");
            Console.WriteLine("Hero vs. Monster, Fight damage calulator\n");



            // Hero stats input HP, ATK, DEF
            Console.Write("Hero Health: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero Defense: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);



            // Monster stats input
            Console.Write("Monsters Health: ");
            bool monHpOk = int.TryParse(Console.ReadLine(), out int monHp);
            Console.Write("Monsters Attack: ");
            bool monAtkOk = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.Write("Monsters Defense: ");
            bool monDefOk = int.TryParse(Console.ReadLine(), out int monDef);



            // Input validation 
            bool isHeroInputValid = heroHpOk && heroAtkOk && heroDefOk;
            bool IsMonInputValid = monHpOk && monAtkOk && monDefOk;
            Console.WriteLine($"\nHERO STATUS VALID: {isHeroInputValid}");
            Console.WriteLine($"MONSTER STATUS VALID: {IsMonInputValid}");

            Console.WriteLine($"[HERO]     HP: {heroHp}, ATK: {heroAtk}, DEF: {heroDef}");
            Console.WriteLine($"[MONSTER]  HP: {monHp}, ATK: {monAtk}, DEF: {monDef}");
            //bool aiiIntValid = isHeroInputValid && IsMonInputValid;
            // ถ้าเอาชื่อ bool มาเช็ค คือ เช็คว่าเป็นจริงมั้ย? แต่ถ้าใส่ !ด้านหน้าคือตรงกันข้าม (จริง -> เท็จ)



            // Compound assignment : += จำลองสภานการณ์ผู้เล่นดื่ม Potion ก่อนต่อสู้
            int potionHeal = 8;
            heroHp = heroHp + potionHeal;       // แบบยาว
            heroHp += potionHeal;               // แบบสั้น ความหมยเดียวกัน  น้ำ potionHeal มา + กับ heroHp
            Console.WriteLine($"\nHero drinks a potion,heals {potionHeal} HP. Hero HP now: {heroHp}");


            // Arithmetiec + โจมตีแบบธรรมดา
            int nmDmg = Math.Max(0, heroAtk - monDef); // ความแรงการโจมตีขึ้นอยู่กับค่าป้องกันของศัตรู
            Console.WriteLine($"\nNormal Attack would deal: {nmDmg} DMG");



            // Precedence การโจมตีพิเศษ Critical Hit 50% chance
            int pwrDmg = Math.Max(0, (heroAtk * 2) - monDef); // โจมตี x2 จะใส่วงเล็บหรือไม่ก็ได้เพราะทำคูณก่อน
            Console.WriteLine($"\nPower Attack would deal: {pwrDmg} DMG");



            // Random, Simple percent of critical chance.
            Random ramdomSmth = new Random();
            int roll = ramdomSmth.Next(10, 101); // ต้อง +1 ค่ามากสุดเสมอ เช่นอยากได้ 100 ต้องใส่ 101
            bool isCrit = roll <= 10; // 10% Chance จาก  100
            int critDmg = nmDmg + Convert.ToInt32(isCrit) * nmDmg; // Bool 1 หรือ 0
            Console.WriteLine($"\n Critical hit roll: {roll} (critical: {isCrit}");
            Console.WriteLine($"If critical;, normal attack would instead deal; {critDmg}");




        }
    }
}
