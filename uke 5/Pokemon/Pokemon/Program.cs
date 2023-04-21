using System.Reflection.Metadata.Ecma335;

namespace Pokemon
{
    internal class Program
    {
        static void Main()
        {
            Start();
        }
        static void Start()
        {
            List<IPokemon> wildPokemon = new List<IPokemon> 
            { 
                new Gengar(15),
                new Gengar(18),
                new Vileplume(24),
                new Vileplume(30),
                new Golem(20),
                new Golem(27)
            };
            StartFight(GetWildPokemon(wildPokemon));
        }
        static void StartFight(IPokemon contender) 
        {
            var magikarp = new Magikarp(RngNum(45, 74));
            
            while (magikarp.Health != 0)
            {
                contender.Attack(magikarp);
                magikarp.Attack(contender);
            }
        }
        static IPokemon GetWildPokemon(List<IPokemon> wildPokemon) 
        {
            return wildPokemon[RngNum(0,wildPokemon.Count)];
        }


        public static int RngNum(int min, int max)
        {
            Random random = new Random();
            int rng = random.Next(min, max);
            return rng;
        }
    }
}