using System.Diagnostics;
using System.Xml.Linq;

namespace rpgGame
{
    internal class Program
    {
        static void Main() 
        {
            MainMenu();
        }
        static void MainMenu() 
        {
            Console.Clear();
            Console.WriteLine("Welcome to RPG Game");
            Console.WriteLine("Press the number of the option you would like to chose.");
            Console.WriteLine("1: Start new game");
            Console.WriteLine("2: Load save");
            Console.WriteLine("3: Exit");
            string choise = Console.ReadLine();
            DetermedChoise(choise );
        }

        static void DetermedChoise(string choise) 
        {
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

        static void StartGame() 
        {
            var party = CreateParty();
            Console.Clear();
            for (int i = 0; i < party.Count; i++) 
            {
                party[i].GetStats();
            }
        }

        static List<Hero> CreateParty()
        {
            var party = new List<Hero>();
            for (int i = 0; i < 3; i++)
            {
                var hero = CreateHero(i);
                party.Add(hero);
            }
            return party;
        }

        static Hero CreateHero(int id)
        {
            Console.Clear();
            Console.WriteLine($"Please type in a name for your {id + 1} hero");
            string name = Console.ReadLine();
            CheckName(name);
            int hp = 100;
            int strength = 20;
            int potionCount = 3;
            int speed = 30;
            var hero1 = new Warrior(id, name, hp, hp, strength, potionCount, speed);
            return hero1;
        }

        static void CheckName(string name) 
        {
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