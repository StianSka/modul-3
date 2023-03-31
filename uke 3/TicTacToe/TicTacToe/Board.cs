using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Board
    {
        private readonly Random _random;
        public Square[] Squares { get; }

        public Board()
        {
            Squares = new Square[9];
            for (int i = 0; i < Squares.Length; i++)
            {
                Squares[i] = new Square();
            }
            _random = new Random();
        }
        public void Mark(string position)
        {
            var collumsChar = position[0];
            var rowChar = position[1];
            var collumIndex = collumsChar - 'a';
            var rowIndex = rowChar - '1';
            var index = rowIndex * 3 + collumIndex;
            Squares[index].Mark(true);
        }
        public void MarkRandom(bool isPlayer1)
        {
            var blankIndexes = new List<int>();
            for (int i = 0; i< Squares.Length; i++)
            {
                if (Squares[i].IsEmpty()) { blankIndexes.Add(i); }
            }
            var ransomPositionInBlankIndexes = _random.Next(blankIndexes.Count);
            var randomInedx = blankIndexes[ransomPositionInBlankIndexes];
            Squares[randomInedx].Mark(isPlayer1);
        }
    }
}
