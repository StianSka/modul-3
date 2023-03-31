using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class GameConsole
    {
        private Board _board;

        public GameConsole(Board board)
        {
            _board = board;
        }
        public void Show()
        {
            Console.Clear();
            Console.WriteLine(@$"  
  a b c
 ┌─────┐
1│{GetContent(0)} {GetContent(1)} {GetContent(2)}│
2│{GetContent(3)} {GetContent(4)} {GetContent(5)}│
3│{GetContent(6)} {GetContent(7)} {GetContent(8)}│
 └─────┘");
        }

        private string GetContent(int index)
        {
            var square = _board.Squares[index];
            return square.IsEmpty() ? " " :
                   square.IsPlayerOne() ? "x" : "o";
            
        }
    }
}
