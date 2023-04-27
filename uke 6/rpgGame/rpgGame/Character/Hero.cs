using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgGame.Character
{
    internal class Hero
    {
        protected int Id;
        protected string Name;
        protected int MaxHp;
        protected int Hp;
        protected int Strength;
        protected int PotionCount;
        protected int Speed;

        public void DrinkPotion()
        {
            if (PotionCount <= 0) { return; }
            if (Hp + 20 > MaxHp) { Hp = MaxHp; PotionCount -= 1; }
            else { Hp += 20; PotionCount -= 1; }
        }

        public void GetStats()
        {
            Console.WriteLine($"Name = {Name}. Index = {Id},");
        }
        public static Hero CreateHero(int id)
        {
            Console.Clear();
            Console.WriteLine($"Please type in a name for your {id + 1} hero");
            string name = Console.ReadLine();
            CheckName(name);
            int hp = 100;
            int strength = 20;
            int potionCount = 3;
            int speed = 30;
            var hero1 = new Warrior(id, name, hp, hp, strength, potionCount, speed);
            return hero1;
        }
        static void CheckName(string name)
        {
            if (name == null || name == "")
            {
                Console.WriteLine("Invalid name: press any key to try again ");
                Console.ReadKey();
            }
            else { return; }
        }




    }
}
