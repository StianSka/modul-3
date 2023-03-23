namespace bossFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rngStrength = RngNum(0, 31);
            GameCharacter hero = new GameCharacter("Hero", 100, 20, 40);
            GameCharacter boss = new GameCharacter("Boss", 400, rngStrength , 10);
            StartFight(hero, boss);
        }

        static void StartFight(GameCharacter hero, GameCharacter boss)
        {
            bool hasWon = false;
            string winner = "";
            while (!hasWon)
            {
                hero.Fight(boss);
                    if (boss.Health <= 0) { hasWon = true; winner = hero.Name; }
                boss.Fight(hero);
                    if (hero.Health <= 0) { hasWon = true; winner = boss.Name; }

            }
            Console.WriteLine("and the winner is " + winner);
        }

        public static int RngNum(int min, int max)
        {
            Random random = new Random();
            int rng = random.Next(min, max);
            return rng;
        }
    }
}