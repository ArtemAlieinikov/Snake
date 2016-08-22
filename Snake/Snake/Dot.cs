using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Dot : IEquatable<Dot>
    {
        protected int x;
        protected int y;
        protected internal char symbol;

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

        public void Move(int sizeOfStep, Direction direct)
        {
            if(direct == Direction.UP)
            {
                this.y -= sizeOfStep;
            }

            if(direct == Direction.DOWN)
            {
                this.y += sizeOfStep;
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

        public void Clear()
        {
            this.symbol= ' ';
            this.Draw();
        }

        public void Draw()
        {
                Console.SetCursorPosition(x, y);
                Console.Write(symbol);
        }

        public bool Equals(Dot item)
        {
            return ((this.x == item.x) && (this.y == item.y));
        }

        public bool IsHit(Dot food)
        {
            return ((this.x == food.x) && (this.y == food.y));
        }

        public override string ToString()
        {
            return String.Format(this.x + " " + this.y + " " + this.symbol);
        }
    }
}
