
namespace pensumsjekkUke3
{
    internal class Program
    {
        static void Main(string[] args) {
            Console.Clear();
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

        static void Feed(string choise, Animal dyr) {
            if (choise != "1") { return; }
            Console.Clear();
            Console.WriteLine("Venligst skriv inn hva du vil mate " + dyr.Name() + " med");
            string food = Console.ReadLine();
            if (dyr.Fav() != food) { dyr.Feed(); }
            else { dyr.Feed(food); }
        }
        public static int RngNum(int min, int max) {
            Random random = new Random();
            int rng = random.Next(min, max);
            return rng;
        }

        //det her er bare å se bort i fra jeg ville bare prøve å se om.
        //jeg kan sende med ett objekt uten å "vite" hvilken klasse det kommer fra 
        public static void Ting(object dyr)
        {

            if (dyr is Animal)
            {
                Animal animal = (Animal)dyr;
                animal.Feed();
            }
        }
    }
}