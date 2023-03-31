using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Square
    {
        private int _content;

        private bool _isEmpty;
        private bool _isPlayerOne;

        public bool IsEmpty()
        {
            return _content == 0;
        }

        public bool IsPlayerOne()
        {
            return _content == 1;
        }
        public void Mark(bool isPlayerOne)
        {
            if (IsEmpty() == false) { return; }
            _content = isPlayerOne ? 1 : 2;
        }
    }
}
