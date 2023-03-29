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
        static void Main(string[] args) {
            Console.Clear();
            MainMenu();
            
            Console.WriteLine("Gi det nye dyret ditt ett navn ");
            string name = Console.ReadLine();
            int age = RngNum(1, 4);
            Console.WriteLine("Dyret heter nå  " + name);
            var dyr = new Animal(name, "Bamsemums", age);
            Console.WriteLine(dyr.Name() + " er " + dyr.Age() + " gammel");
            Console.WriteLine("Trykk 1 for å mate " + dyr.Name());
            string choise = Console.ReadLine();
            Feed(choise, dyr);
        }

        private static void MainMenu() {
            Console.WriteLine("velkommen her kan du vlege å adoptere ett nytt kjeledyr");
            Console.WriteLine("trykk på 1; for å velge dyr 1");
            Console.WriteLine("trykk på 2; for å velge dyr 2");
            Console.WriteLine("trykk på 3; for å velge dyr 3");
            string choise = Console.ReadLine();
        }

        static void Feed(string choise, Animal dyr) {
            if (choise != "1") { return; }
            Console.Clear();
            Console.WriteLine("Venligst skriv inn hva du vil mate " + dyr.Name() + " med");
            string food = Console.ReadLine();
            if (dyr.Fav() != food) { dyr.Feed(); }
            else { dyr.Feed(food); }
        }
        static int RngNum(int min, int max) {
            Random random = new Random();
            int rng = random.Next(min, max);
            return rng;
        }

        //det her er bare å se bort i fra jeg ville bare prøve å se om.
        //jeg kan sende med ett objekt uten å "vite" hvilken klasse det kommer fra 
        static void Ting(object dyr)
        {

            if (dyr is Animal)
            {
                Animal animal = (Animal)dyr;
                animal.Feed();
            }
        }
    }
}