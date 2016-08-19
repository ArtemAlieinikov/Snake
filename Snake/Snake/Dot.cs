using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Dot
    {
        private int x;
        private int y;
        private char symbol;

        public Dot(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
