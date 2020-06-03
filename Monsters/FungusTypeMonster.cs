using System;

namespace PocketMonsters.Monsters
{
    public class FungusTypeMonster : Monster
    {
        public FungusTypeMonster (string Name, int Level, int Attack, int Defense, int MaxHP) : base (Name, Level, Attack, Defense, MaxHP) { }

        public override void DoAttack(Monster target)
        {
            if(target is MeatTypeMonster)
            {
                Random rand = new Random();
                // give me a random number between 1 and 20
                int roll = rand.Next(1,21);
                int damage = 0;
                if(roll == 20) 
                {
                    // critical success!
                    damage = (int) 2.25 * (Attack - (target.Defense/3));
                    Console.WriteLine($"Critical Hit! {target.Name} takes {damage} damage! It's super effective!");
                } 
                else if(roll > 4)
                {
                    // just a hit
                    damage = (int) 1.5 * (Attack - (target.Defense/3));
                    Console.WriteLine($"Hit! {target.Name} takes {damage} damage! It's super effective!");
                }
                else
                {
                    // miss
                    Console.WriteLine($"Miss! {Name} missed the mark!");
                }
                target.ApplyDamage(damage);
            } else {
                base.DoAttack(target);
            }
        }
    }
}