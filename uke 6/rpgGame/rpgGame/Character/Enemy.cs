using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgGame.Character
{
    internal class Enemy
    {
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




    }

}
