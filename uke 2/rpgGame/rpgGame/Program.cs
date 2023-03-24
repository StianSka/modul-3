using System.Diagnostics;
using System.Xml.Linq;

namespace rpgGame
{
    internal class Program
    {
        static void Main() {
            MainMenu();
        }
        static void MainMenu() {
            Console.Clear();
            Console.WriteLine("Wlecome to RPG Game");
            Console.WriteLine("Press the number of the option you would like to chose.");
            Console.WriteLine("1: Start new game");
            Console.WriteLine("2: Load save");
            Console.WriteLine("3: Exit");
            string choise = Console.ReadLine();
            DetermedChoise(choise );
        }

        static void DetermedChoise(string choise) {
            switch (choise)
            {
                case "1":
                    StartGame();
                    break;
                case "2":
                    Console.WriteLine("not implemented: press any key to return to main menu");
                    Console.ReadKey();
                    Main();
                    break; 
                case "3":
                    Console.WriteLine("Good bye");
                    break;
                default:
                    Console.WriteLine("Unexpected command: press any key to return to main menu");
                    Console.ReadKey();
                    Main();
                    break;
            }
        }

        static void StartGame() {
            Console.Clear();
            Console.WriteLine("Please type in a name for your first hero");
            string name = Console.ReadLine();
            CheckName(name);
            int hp = 100;
            int strength = 20;
            int potionCount = 3;
            int speed = 30;
            var hero1 = new Goblin( name, hp, hp,  strength,  potionCount, speed);
            name = "Peasant 1";
            hp = 80;
            potionCount = 2;
            speed = 20;
            var enemy1 = new Goblin(name, hp, hp, strength, potionCount, speed);
            StartBattle(hero1, enemy1);
        }

        static void StartBattle(object hero, object enemy) {
            
        }

        static void CheckName(string name) {
            if (name == null || name == "")
            {
                Console.WriteLine("Invalid name: press any key to try again ");
                Console.ReadKey();
                StartGame();
            }
            else { return; }
        }
    }
}