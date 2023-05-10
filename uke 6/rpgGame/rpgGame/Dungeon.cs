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

        public List<Battle> Party = new List<Battle>();

        public int NumOfBattles { get; private set; }

        public Dungeon(Enemy boss, int battleCount) 
        {
            Boss = boss;
            NumOfBattles = battleCount;
        }
        public static void StartDungeon()
        {
            Enemy boss = new Goblin("Mork", 1000, 1000, 80, 5, 30);
            int battleCount = Program.RandomNumber(1,4);
            Dungeon current = new Dungeon(boss,battleCount);

        }




    }
}
