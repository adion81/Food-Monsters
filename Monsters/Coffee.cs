using System;

namespace PocketMonsters.Monsters
{
    public class Coffee : IPotion
    {
        public string Name {get; set;} = "Coffee";

        public void Use(Monster target)
        {
            target.Attack *= 2;
            target.Name = "Angry " + target.Name;
            Console.WriteLine($"{target.Name} now {target.Name} SMASH!!!");
        }
    }
}