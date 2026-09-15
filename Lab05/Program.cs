/*
 * Student ID : 1690702095
 * Name       : Lab05
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game title, Sub-title
            Console.WriteLine("============== Dungeon & Dragon ==============");
            Console.WriteLine("Hero vs. Monster, Fight damage calculator\n");

            // Hero stats input
            Console.Write("Hero Health: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero Defense: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);

            // Monster stats input
            Console.Write("Monster Health: ");
            bool monHpOk = int.TryParse(Console.ReadLine(), out int monHp);
            Console.Write("Monster Attack: ");
            bool monAtkOk = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.Write("Monster Defense: ");
            bool monDefOk = int.TryParse(Console.ReadLine(), out int monDef);

            // Input validation
            bool isHeroIntValid = heroHpOk && heroAtkOk && heroDefOk;
            bool isMonIntValid = monHpOk && monAtkOk && monDefOk;
            Console.WriteLine($"\nHERO STATUS VALID: {isHeroIntValid}");
            Console.WriteLine($"MONSTER STATUS VALID: {isMonIntValid}");

            Console.WriteLine($"[HERO]       HP: {heroHp} ATK: {heroAtk} DEF: {heroDef}");
            Console.WriteLine($"[MONSTER]    HP: {monHp} ATK: {monAtk} DEF: {monDef}");

            //bool allIntValid = isHeroIntValid && isMonIntValid;
            //ถ้าเอาแค่ชื่อ bool มาเช็ค คือ เช็คว่าเป็นจริงมั้ย? แต่ถ้าใส่ ! ด้านหน้าคือตรงข้าม (จริง -> เท็จ)

            // Compound assigment : ++ จำลองสถานการณ์ผู้เล่นดื่ม Potion ก่อนสู้
            int potionHeal = 8;
            //heroHp = heroHp + potionHeal;     // แบบยาว
            heroHp += potionHeal;               // แบบสั้น ความหมายเดียวกัน นำ potionHeal มา + กับ heroHp
            Console.WriteLine($"\nHero drinks a potion, healing {potionHeal} HP. Hero Hp now {heroHp} HP");

            // Arithmetic + การโจมตีธรรมดา
            int normalDmg = Math.Max(0, heroAtk - monDef); //ความแรงการโจมตีขึ้นอยู่กับค่าป้องกันของศัตรู
            Console.WriteLine($"\nNormal Attack would deal: {normalDmg} DMG");

            // Precedence การโจมตีพิเศษ
            int pwrDmg = Math.Max(0, (heroAtk * 2) - monDef); //โจมตี x2 จะใส่วงเล็บหรือไม่ก็ได้เพราะทำคูณก่อน
            Console.WriteLine($"\nPower Attak would deal: {pwrDmg} DMG");

            // Random, Simple percent critical chance.
            Random rngCrit = new Random();
            int roll = rngCrit.Next(1, 11); //ต้อง +1 ค่ามากสุดเสมอ เช่นอยากได้ 100 ต้อง 101
            bool isCrit = roll <= 10; // 10% Chance จาก 100
            int critDmg = normalDmg + Convert.ToInt32(isCrit) * normalDmg; // Bool 1 หรือ 0
            Console.WriteLine($"Critical hit roll: {roll} (critical: {isCrit}");
            Console.WriteLine($"If critical, normal attak would instead deal: {critDmg}");

        }
    }
}
