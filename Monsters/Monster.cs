using System;
using System.Collections.Generic;

namespace PocketMonsters.Monsters
{
    public abstract class Monster
    {
        public string Name;
        public int Level;
        public int Attack;
        public int Defense;
        private int MaxHP;
        protected int HP;

        public int GetHP
        {
            get{return HP;}
        }

        public bool IsMaxOut
        {
            get {return HP >= MaxHP;}
        }

        public List<IPotion> PotionBag;


        public bool isActive {
            get {
                return HP > 0;
            }
        }

        public Monster(string Name, int Level, int Attack, int Defense, int MaxHP)
        {
            this.Name = Name;
            this.Level = Level;
            this.Attack = Attack;
            this.Defense = Defense;
            this.MaxHP = MaxHP;
            this.HP = MaxHP;
            this.PotionBag = new List<IPotion>();
        }

        public void ApplyDamage(int Damage)
        {
            HP -= Damage;

            if(HP < 0 )
            {
                HP = 0;
            }
            else if(HP > MaxHP)
            {
                HP = MaxHP;
            }
        }

        public virtual void DoAttack(Monster target)
        {
            Random rand = new Random();
            // give me a random number between 1 and 20
            int roll = rand.Next(1,21);
            int damage = 0;
            if(roll == 20) 
            {
                // critical success!
                damage = (int) 1.5 * (Attack - (target.Defense/3));
                Console.WriteLine($"Critical Hit! {target.Name} takes {damage} damage!");
            } 
            else if(roll > 4)
            {
                // just a hit
                damage = Attack - (target.Defense/3);
                Console.WriteLine($"Hit! {target.Name} takes {damage} damage!");
            }
            else
            {
                // miss
                Console.WriteLine($"Miss! {Name} missed the mark!");
            }
            target.HP -= damage;
        }

    }
}