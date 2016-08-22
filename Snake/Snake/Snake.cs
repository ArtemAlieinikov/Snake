using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    class Snake : Figure
    {
        Direction directionOfMoving;
        Dot nextHeadDot;
        int snakeSpeed;

        public Snake(Dot tail, int length, Direction direct, int speed)
        {
            length = length <= 1 ? 2 : length;
            directionOfMoving = direct;
            snakeSpeed = speed;

            for(int i = 0; i < length; i++)
            {
                Dot snakeDot = new Dot(tail);
                snakeDot.Move(i, directionOfMoving);
                dotList.Add(snakeDot);
            }
        }

        public void Move()
        {
            Thread.Sleep(snakeSpeed);

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

        public bool IsEating(Dot food)
        {
            if(nextHeadDot.IsHit(food))
            {
                food.symbol = nextHeadDot.symbol;
                food.Move(1, directionOfMoving);

                dotList.Insert(0, food);

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsCollision(GameField walls)
        {
            List<Dot> snakeWithoutHead = this.dotList.Take(this.dotList.Count - 1).ToList();
            if (snakeWithoutHead.Contains(nextHeadDot))
                return true;

            foreach(Line gameFieldLine in walls.fence)
            {
                if (gameFieldLine.dotList.Contains(nextHeadDot))
                    return true;
            }

            foreach (Line gameFieldLine in walls.barrier)
            {
                if (gameFieldLine.dotList.Contains(nextHeadDot))
                    return true;
            }

            return false;
        }
    }
}
