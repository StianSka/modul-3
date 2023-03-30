/*Lag en konsoll applikasjon hvor man kan generere opp flere forskjellige virtuelle kjæledyr.
Bruk constructor i klassen, og man skal ikke ha lov til å endre data som navn,
age eller noen andre characteristics utenfra klassen.

Lag funksjonalitet som gjør at man kan gi dyret mat,
bruk en overload til å gi en annen feedback til console dersom det er favorittmaten til dyret 
f eks “Hurra dette er det beste jeg vet tusen takk for maten!” istedenfor f.eks “Takk for maten”.
*/

namespace pensumsjekkUke3
{
    internal class Program
    {
        static List<Animal> myPets = new List<Animal>();
        static string[] foods = { "roasted chicken", "cotton candy", "cupcakes", "shrimp", "lobster", "curry", "roast beef", "hearty stew", };
        static void Main(string[] args) {
            NewAnimalMenu();
        }

        static void NewAnimalMenu() 
        {
            Console.Clear();
            Console.WriteLine("welcome please follow the instructions to choose a new pet");
            Console.WriteLine("press 1; to adopt a Dragon");
            Console.WriteLine("press 2; to adopt a Unicorn");
            Console.WriteLine("press 3; to adopt a Phoenix");
            Console.WriteLine("press 4; to adopt a Griffin");
            Console.WriteLine("press 5; to adopt a Pegasus");
            ConsoleKeyInfo choise = Console.ReadKey();
            string type = ChosePet(choise);
            CreateCreature(type);
        }

        static void CreateCreature(string type)
        {
            Console.Clear();
            Console.WriteLine("please give your new " + type + " a fitting name then press enter");
            string name = Console.ReadLine();
            string fav = foods[RngNum(0, foods.Length)];
            int age = RngNum(1, 4);
            Animal pet = new Animal(name, type ,fav, age);
            myPets.Add(pet);
            Console.Clear();
            pet.Summary();
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            PlayMenu();
        }

        static void PlayMenu()
        {
            Console.Clear();
            Console.WriteLine("press 1: to feed animal");
            Console.WriteLine("press 2: to see all animal");
            Console.WriteLine("press 3: to adopt a new animal");  
            ConsoleKeyInfo choise = Console.ReadKey();
            SelectAction(choise);
        }

        static void SelectAction(ConsoleKeyInfo choise)
        {
            
            if (choise.KeyChar == '1') { SelecktAnimal(); }
            else if (choise.KeyChar == '2') { ShowAnimals(); }
            else if (choise.KeyChar == '3') { NewAnimalMenu(); }
            else { PlayMenu(); }
        }

        static void ShowAnimals()
        {
            ListAnimals("List");
            Console.WriteLine("press any key to return");
            Console.ReadKey();
            PlayMenu();
        }

        static void SelecktAnimal()
        {
            ListAnimals("Feed");
            Console.WriteLine("please write the number that corresponds to the animal you would like to feed. Then press enter ");
            string choise = Console.ReadLine();
            FeedMenu(choise);
        }

        static void FeedMenu(string choise)
        {
            int petIndex = Convert.ToInt32(choise) - 1 ;
            Console.Clear();
            Console.WriteLine("please write the number that corresponds to the food you would like to give to " + myPets[petIndex].Name());
            ListFood();
            string food = Console.ReadLine();
            int foodIndex = Convert.ToInt32(food) - 1;

            if (myPets[petIndex].Fav() != foods[foodIndex]) { myPets[petIndex].Feed(); }
            else { myPets[petIndex].Feed(foods[foodIndex]); }
            Console.WriteLine("press ant key to return");
            Console.ReadKey();
            PlayMenu();
        }

        static void ListFood()
        {
            for (int i = 0; i < foods.Length; i++)
            {
                Console.WriteLine($"press {(i + 1)}: for {foods[i]}");
            } 
        }

        static void ListAnimals(string toDo)
        {
            Console.Clear();
            for (int i = 0; i < myPets.Count; i++)
            {
                Console.Write((i + 1) + " ");
                if (toDo == "List") { myPets[i].Summary(); }
                else if(toDo == "Feed") { Console.WriteLine(myPets[i].Name() + " the " + myPets[i].Type()); }
            }
        }

        static string ChosePet(ConsoleKeyInfo choise)
        {
            string type = "";
            switch (choise.KeyChar)
            {
                case '1':
                    type = "Dragon";
                    break;
                case '2':
                    type = "Unicorn";
                    break;
                case '3':
                    type = "Phoenix";
                    break;
                case '4':
                    type = "Griffin";
                    break;
                case '5':
                    type = "Pegasus";
                    break;
                default:
                    NewAnimalMenu();
                    break;
            }
            return type;
        }

        static int RngNum(int min, int max) 
        {
            Random random = new Random();
            int rng = random.Next(min, max);
            return rng;
        }   
    }
}