namespace main_metode_oppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
                Console.WriteLine(args.Length);
        }
    }
}