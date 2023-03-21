using System.Reflection.Metadata.Ecma335;

namespace variabeltilordning_oppgave
{
    internal class Program
    {
        //int, long, float, decimal, double, string, char og bool
        int helTall = 39;
        long helTaleHuge = 3216387126;
        float kommmaTallSmol = 0.03f;   // need the f dude
        double kommatall = 0.005;
        decimal kommaTallHuge = 0.127631287361m; // need the m dude 
        string tekst = "HA HA is text";
        char enkeltTegn = 'B';
        bool santUsant = true;

       

        static void Main(string[] args)
        {
            int alder = 27;
            int alder2 = 16;
            Console.WriteLine(summer(alder, alder2));
            printNothing();
            Console.WriteLine(returnSomthing());

        }
       
        static int summer(int a, int b)
        {
            int sum = a + b;
            return sum;      
        }

        static void printNothing()
        {
            Console.WriteLine("Shalom denne metoden returnerer ingenting");
        }

        static string returnSomthing()
        {
            string tekst = "Shalom denne teksten er returnert";
            return tekst;
        }


    }
}