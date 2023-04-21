using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Golem : IPokemon
    {
        public string Name { get; }
        public int Health { get; set; }
        public Golem(int health)
        {
            Name = "Golem";
            Health = health;
        }
        public void Attack(IPokemon victim)
        {
            victim.LoseHealth(Program.RngNum(10, 20));
        }
        public void LoseHealth(int damage)
        {
            Health -= damage;
            if (Health < 0) { Health = 0; }
            Console.WriteLine($"{Name} tokk {damage} damage it's hp is now {Health}");
        }
    }
}
