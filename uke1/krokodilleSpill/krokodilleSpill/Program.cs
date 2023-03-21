namespace krokodilleSpill
{
    internal class Program
    {
        static int firstNum = RngNums();
        static int secondNum = RngNums();
        static string ansewar = "";
        static bool isCoreckt = false;
        static int score = 0;
        static void Main(string[] args)
        {
            StartGame();
        }
        static void StartGame()
        {
            Console.WriteLine("Halo dette er krokodille spillet du vil få to tall. " +
                "Din oppgave vil være å si om tall en er mindre");
            Console.WriteLine("enn eller større enn eller likt tall to. Her kommer de første tallene");
            NextRound();
        }

        static void GiveAnswear()
        {
            if (isCoreckt)
            {
                score++;
                Console.WriteLine("Riktig!!! du har nå " + score + " poeng");
            }
            else
            {
                score--;
                Console.WriteLine("Nope! du har nå "+ score +" poeng");
            }
            ContinuePlaying();
        }
        static void ContinuePlaying()
        {
            if(ansewar == "=" || ansewar == "<" || ansewar == ">")
            {
                NextRound();
            }
        }

        static void NextRound()
        {
            ansewar = "";
            firstNum = RngNums();
            secondNum = RngNums();
            isCoreckt = false;
            Console.WriteLine("tall en: " + firstNum + " tall to: " + secondNum);
            ansewar = Console.ReadLine();
            isCoreckt = CheckAnswear();
            GiveAnswear();
        }
        static bool CheckAnswear()
        {
            bool check = false;
            if (ansewar == "<" && firstNum < secondNum)
            {
                check = true;
            }
            else if (ansewar == ">" && firstNum > secondNum)
            {
                check = true;
            } 
            else if (ansewar == "=" && firstNum == secondNum)
            {
                check = true;
            }
            return check;
        } 
        static int RngNums()
        {
            Random random = new Random();
            int rng = random.Next(1, 12);
            return rng;
        }
    }
}