using System;
using PocketMonsters.Monsters;

namespace PocketMonsters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!!FOOD MONSTERS!!!");
            Monster Pikablue = new VegetableTypeMonster("Pikablue", 8,  36, 55, 44);
            Monster NicCage  = new FungusTypeMonster("NicCage" , 10, 45, 30, 50);


            Pikablue.PotionBag.Add(new Potion("Lesser Potion",2));
            Pikablue.PotionBag.Add(new Potion("Mega Potion",10));
            Pikablue.PotionBag.Add(new Coffee());
            while(NicCage.isActive && Pikablue.isActive)
            {
                NicCage.DoAttack(Pikablue);
                Pikablue.DoAttack(NicCage);
            }

            while(!Pikablue.IsMaxOut)
            {
                Pikablue.PotionBag[0].Use(Pikablue);
            }
            Console.WriteLine($"NicCage: {NicCage.isActive}");
            Console.WriteLine($"Pikablue: {Pikablue.isActive}");

            Pikablue.PotionBag[1].Use(NicCage);
            Pikablue.PotionBag[2].Use(Pikablue);
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
