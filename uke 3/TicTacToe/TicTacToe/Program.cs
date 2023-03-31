namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var board = new Board();
            var gameConsole = new GameConsole(board);
            while (true)
            {
                gameConsole.Show();
                Console.WriteLine("Skriv in hvor du vil sette kryss for eksempel \"a2\"");
                var posision = Console.ReadLine();
                board.Mark(posision);
                gameConsole.Show();
                Thread.Sleep(1000);
                board.MarkRandom(false);

            }
        }
    }
}