using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction directionOfMoving;
        Dot nextHeadDot;

        public Snake(Dot tail, int length, Direction direct)
        {
            length = length <= 1 ? 2 : length;
            directionOfMoving = direct;

            for(int i = 0; i < length; i++)
            {
                Dot snakeDot = new Dot(tail);
                snakeDot.Move(i, directionOfMoving);
                dotList.Add(snakeDot);
            }
        }

        public void Move()
        {
            Dot tail = dotList.First();
            dotList.Remove(tail);

            nextHeadDot = GetNextDot();
            dotList.Add(nextHeadDot);

            tail.Clear();
            nextHeadDot.Draw();
        }

        private Dot GetNextDot()
        {
            Dot previousHeadDot = dotList.Last();
            nextHeadDot = new Dot(previousHeadDot);

            nextHeadDot.Move(1, directionOfMoving);

            return nextHeadDot;
        }

        public void KeyPushReaction(ConsoleKey key)
        {
            if((key == ConsoleKey.W) || (key == ConsoleKey.UpArrow))
            {
                if(directionOfMoving != Direction.DOWN)
                {
                    directionOfMoving = Direction.UP;
                }
            }

            if ((key == ConsoleKey.S) || (key == ConsoleKey.DownArrow))
            {
                if (directionOfMoving != Direction.UP)
                {
                    directionOfMoving = Direction.DOWN;
                }
            }

            if ((key == ConsoleKey.A) || (key == ConsoleKey.LeftArrow))
            {
                if (directionOfMoving != Direction.RIGHT)
                {
                    directionOfMoving = Direction.LEFT;
                }
            }

            if ((key == ConsoleKey.D) || (key == ConsoleKey.RightArrow))
            {
                if (directionOfMoving != Direction.LEFT)
                {
                    directionOfMoving = Direction.RIGHT;
                }
            }
        }

        public bool IsEat(Dot food)
        {
            if(nextHeadDot.IsHit(food))
            {
                food.symbol = nextHeadDot.symbol;
                dotList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
