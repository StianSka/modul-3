using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal interface IPokemon
    {
        string Name { get; }
        int Health { get; set; }

        void Attack(IPokemon victim);
        void LoseHealth(int damage);
    }
}
