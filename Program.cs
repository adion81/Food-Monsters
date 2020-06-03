using System;
using PocketMonsters.Monsters;

namespace PocketMonsters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Monster Pikablue = new VegetableTypeMonster("Pikablue", 8,  36, 55, 44);
            Monster NicCage  = new FungusTypeMonster("NicCage" , 10, 45, 30, 50);
            while(NicCage.isActive && Pikablue.isActive)
            {
                NicCage.DoAttack(Pikablue);
                Pikablue.DoAttack(NicCage);
            }
            Console.WriteLine($"NicCage: {NicCage.isActive}");
            Console.WriteLine($"Pikablue: {Pikablue.isActive}");
        }
    }
}
