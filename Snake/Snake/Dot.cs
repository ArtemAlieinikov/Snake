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

        public Dot(Dot item)
        {
            x = item.x;
            y = item.y;
            symbol = item.symbol;
        }

        internal void Move(int sizeOfStep, Direction direct)
        {
            if(direct == Direction.UP)
            {
                this.y += sizeOfStep;
            }

            if(direct == Direction.DOWN)
            {
                this.y -= sizeOfStep;
            }

            if (direct == Direction.RIGHT)
            {
                this.x += sizeOfStep;
            }

            if (direct == Direction.LEFT)
            {
                this.x -= sizeOfStep;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
