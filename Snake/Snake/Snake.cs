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
            for(int i = 0; i <= length; i++)
            {
                Dot snakeDot = new Dot(tail);
                snakeDot.Move(i, direct);
                dotList.Add(snakeDot);
            }
        }
    }
}
