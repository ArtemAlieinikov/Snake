using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Line : Figure
    {
        public Line(int firstPosition, int lineLength, int HeightWidthLine, HorizontalVertical direction, char symbol)
        {
            if(direction == HorizontalVertical.HORIZONTAL)
            {
                for(int x = firstPosition; x <= lineLength; x++)
                {
                    dotList.Add(new Dot(x, HeightWidthLine, symbol));
                }
            }

            else 
            {
                for (int y = firstPosition; y <= lineLength; y++)
                {
                    dotList.Add(new Dot(HeightWidthLine, y, symbol));
                }
            }
        }
    }
}
