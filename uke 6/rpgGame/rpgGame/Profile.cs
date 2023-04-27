using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rpgGame.Character;

namespace rpgGame
{
    internal class Profile
    {
        public static int Gold;
        public static List<Hero> Party = new List<Hero>();
        // public List<Items> Loot;

        public static void FillParty()
        {
            for (int i = 0; i < 3; i++)
            {
                var hero = Hero.CreateHero(i);
                Party.Add(hero);
            }
        }



    }
}
