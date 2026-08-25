/*
 * Student ID : 1690702095
 * Name       : Lab02
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

using static System.Net.Mime.MediaTypeNames;

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
            // ประกาศตัวแปร 6 ตัว
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is boss: {isBoss}");

            Console.WriteLine();
            //คำนวณเปอร์เซ็น
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"Hp Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();
            //ลด HP 60 หน่วย
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"Hp Percent: {hpPercent}%");

            string p1name = "ICQ";
            string p2name = "Bike";
            string p3name = "Ton";
            string p4name = "Big";
            char p1rank = 'S';
            char p2rank = 'S';
            char p3rank = 'A';
            char p4rank = 'F';
            int p1level = 99;
            int p2level = 99;
            int p3level = 67;
            int p4level = 10;
            int MaxHp = 100;
            float p1walkspeed = 24.5f;
            double p1runspeed = 49;
            float p2walkspeed = 15.5f;
            double p2runspeed = 31;
            float p3walkspeed = 10.5f;
            double p3runspeed = 21;
            float p4walkspeed = 5.5f;
            double p4runspeed = 11;
            bool isFat = true;
            Console.WriteLine("===RPG Game Player Stat===");
            Console.WriteLine($"Player 1 Name: {p1name}");
            Console.WriteLine($"Player 1 Rank: {p1rank}");
            Console.WriteLine($"HP: {MaxHp}");
            Console.WriteLine($"Player 1 walk speed: {p2walkspeed}");
            Console.WriteLine($"Player 1 run speed: {p2runspeed}");
            Console.WriteLine();
            Console.WriteLine($"Player 2 Name: {p2name}");
            Console.WriteLine($"Player 2 Rank: {p2rank}");
            Console.WriteLine($"HP: {MaxHp}");
            Console.WriteLine($"Player 2 walk speed: {p2walkspeed}");
            Console.WriteLine($"Player 2 run speed: {p2runspeed}");
            Console.WriteLine();
            Console.WriteLine($"Player 3 Name: {p3name}");
            Console.WriteLine($"Player 3 Rank: {p3rank}");
            Console.WriteLine($"HP: {MaxHp}");
            Console.WriteLine($"Player 3 walk speed: {p3walkspeed}");
            Console.WriteLine($"Player 3 run speed: {p3runspeed}");
            Console.WriteLine();
            Console.WriteLine($"Player 4 Name: {p4name}");
            Console.WriteLine($"Player 4 Rank: {p4rank}");
            Console.WriteLine($"HP: {MaxHp}");
            Console.WriteLine($"Player 4 walk speed: {p4walkspeed}");
            Console.WriteLine($"Player 4 run speed: {p4runspeed}");
            Console.WriteLine($"Is fat {isFat}");
            Console.WriteLine();
            Console.WriteLine("End Thank you for reading :D");
        }
    }
}
