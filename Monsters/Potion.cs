using System;

namespace PocketMonsters.Monsters
{
    public class Potion : IPotion
    {
        public string Name {get; set;}

        public int Strength {get; set;}

        public Potion(string name, int str)
        {
            Name = name;
            Strength = str;
        }
        public void Use(Monster target)
        {
            target.ApplyDamage(-5 * Strength);
            Console.WriteLine($"{Name} was used on {target.Name}\n{target.Name}'s health is now {target.GetHP}!");
        }
    }
}