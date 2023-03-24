using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgGame
{
    internal class Goblin
    {
        private string _name;
        private int _maxHp;
        private int _hp;
        private int _strength;
        private int _potionCount;
        private int _speed;

        public Goblin(string name, int maxHp, int hp, int strength, int potionCount, int speed)
        {
            _name = name;
            _maxHp = maxHp;
            _hp = hp;
            _strength = strength;
            _potionCount = potionCount;
            _speed = speed;
        }

        public void DrinkPotion() {
            if (this._potionCount <= 0) { return; }
            if (this._hp + 20 > this._maxHp) { this._hp = this._maxHp; this._potionCount -= 1; }
            else { this._hp += 20; this._potionCount -= 1; }

        }
        public int BasicAttack()
        {
            return this._strength;
        }
    }
}
