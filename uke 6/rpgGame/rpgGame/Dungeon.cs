using rpgGame.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace rpgGame
{
    internal class Dungeon
    {
        public Enemy Boss { get; private set; }
        public int Battles { get; private set; }

        public Dungeon(Enemy boss, int battles) 
        {
            Boss = boss;
            Battles = battles;
        }
        public static void StartDungeon()
        {
            Enemy boss = new Goblin("Mork", 1000, 1000, 80, 5, 30);
            int battles = Program.RandomNumber(1,4);
            Dungeon current = new Dungeon(boss,battles);

        }




    }
}
