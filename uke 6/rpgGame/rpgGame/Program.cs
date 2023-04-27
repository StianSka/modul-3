using System.Diagnostics;
using System.Xml.Linq;
using rpgGame.Character;

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
            ConsoleKeyInfo choice = Console.ReadKey();
            DetermedMainChoise(choice);
        }

        static void DetermedMainChoise(ConsoleKeyInfo choice) 
        {
            switch (choice.KeyChar)
            {
                case '1':
                    CreateProfile();
                    break;
                case '2':
                    Console.WriteLine("not implemented: press any key to return to main menu");
                    Console.ReadKey();
                    Main();
                    break; 
                case '3':
                    Console.WriteLine("Good bye");
                    break;
                default:
                    Console.WriteLine("Unexpected command: press any key to return to main menu");
                    Console.ReadKey();
                    Main();
                    break;
            }
        }

        static void CreateProfile()
        {
            Profile.FillParty();
            StartGame();
        }

        static void StartGame() 
        {
            GameMenu();
        }
        static void GameMenu()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Press the number of the option you would like to chose.");
            Console.WriteLine("1: Go to the shop");
            Console.WriteLine("2: Go explore a random dungeon");
            ConsoleKeyInfo choice = Console.ReadKey();
            Console.Clear();
            DetermedGameChoise(choice);
        }
        static void DetermedGameChoise(ConsoleKeyInfo choice)
        {
            switch (choice.KeyChar)
            {
                case '1':
                    Console.WriteLine("not implemented: press any key to return");
                    Console.ReadKey();
                    GameMenu();
                    break;
                case '2':
                    Console.WriteLine("Have fun on your adventure");
                    Console.ReadKey();
                    StartDungeon();
                    break;
                default:
                    Console.WriteLine("Unexpected command: press any key to return");
                    Console.ReadKey();
                    GameMenu();
                    break;
            }
        }

        static void StartDungeon()
        {
            Console.Clear();
            foreach (var hero in Profile.Party)
            {
                hero.GetStats();
            }
        }
    }
}