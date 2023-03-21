namespace løkke_oppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForLoop();
            ForEach();
            WhileLoop();
        }
        static void ForLoop()
        {
            for(int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Terje er kul");
            }
        }
        static void ForEach()
        {
            string tekst = "yo hva skjer ";
            foreach (var arg in tekst)
            {
                Console.WriteLine(arg);
            }
        }
        static void WhileLoop()
        {
            int i = 0;
            while (i < 10)
            {
                i++;
                Console.WriteLine(i);
            }
        }
    }
}