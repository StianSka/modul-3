using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace rpgGame.Character
{
    internal class Warrior : Hero
    {
        public Warrior(int id, string name, int maxHp, int hp, int strength, int potionCount, int speed) 
        {
            Id = id;
            Name = name;
            MaxHp = maxHp;
            Hp = hp;
            Strength = strength;
            PotionCount = potionCount;
            Speed = speed;
        }
        




    }
}
