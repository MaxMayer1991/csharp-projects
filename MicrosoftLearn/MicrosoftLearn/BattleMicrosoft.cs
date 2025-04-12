using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lessons
{
    internal class BattleMicrosoft
    {
        static void main(string[] args)
        {
            int monsterHealth = 10;
            int playerHealth = 10;
            int attackDamage = 0;
            Random random = new Random();
            do
            {
                attackDamage = random.Next(1,11);
                monsterHealth -= attackDamage;
                Console.WriteLine($"Hero Attacs with damage: {attackDamage}\nMonster health: {monsterHealth}");
                if (monsterHealth <= 0) continue; 
                attackDamage = random.Next(1, 11);
                playerHealth -= attackDamage;
                Console.WriteLine($"Monster Attacs with damage: {attackDamage}\nPlayer health: {playerHealth}");


            }
            while (monsterHealth <= 0 && playerHealth <= 0);
            Console.WriteLine(playerHealth > monsterHealth ? "Hero wins!" : "Monster wins!");
        }
    }
}
