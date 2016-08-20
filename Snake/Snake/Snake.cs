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

        public Snake(Dot tail, int length, Direction direct)
        {
            directionOfMoving = direct;

            for(int i = 0; i <= length; i++)
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

            Dot head = GetNextDot();
            dotList.Add(head);

            tail.Clear();
            head.Draw();
        }

        private Dot GetNextDot()
        {
            Dot previousHeadDot = dotList.Last();
            Dot nextHeadDot = new Dot(previousHeadDot);

            nextHeadDot.Move(1, directionOfMoving);

            return nextHeadDot;
        }
    }
}
