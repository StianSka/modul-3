using System.Diagnostics;
using System.Xml.Linq;
using rpgGame.Character;

namespace rpgGame
{
    internal class Program
    {
        static void Main() 
        {
            Menu.MainMenu();
        }
        public static int RandomNumber(int min, int max)
        {
            Random result = new Random();
            result.Next(min, max);
            return result.Next();
        }
        
    }
}