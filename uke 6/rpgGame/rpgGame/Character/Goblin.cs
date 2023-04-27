using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgGame.Character
{
    internal class Goblin : Enemy
    {
        public Goblin(string name, int maxHp, int hp, int strength, int potionCount, int speed)
        {
            Name = name;
            MaxHp = maxHp;
            Hp = hp;
            Strength = strength;
            PotionCount = potionCount;
            Speed = speed;
        }


    }
}
