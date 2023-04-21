using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Magikarp : IPokemon
    {
        public string Name { get; }    
        public int Health { get; set; }
        public string IsUseless { get; set; }

        public Magikarp(int health) 
        {
            Name = "Magikarp";
            Health = health;
            IsUseless = "";
        }

        public void Splash(IPokemon victim)
        {
            
            Console.WriteLine($"{Name} is splashing");
            Console.WriteLine($"{victim.Name} is not impressed by {Name}'s splashing");
            Console.WriteLine($"{victim.Name} is unaffected by {Name}'s splashing");
        }
        public void Attack(IPokemon victim)
        {
            Splash(victim);
        }
        public void LoseHealth(int damage)
        {
            Health -= damage;
            if (Health < 0) { Health = 0; }
            Console.WriteLine($"{Name} tokk {damage} damage it's hp is now {Health}");
        }
    }
}
