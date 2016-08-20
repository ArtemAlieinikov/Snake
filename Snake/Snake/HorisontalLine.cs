using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    //This class used for building horisontal lines
    class HorisontalLine : Figure
    {
        public HorisontalLine(int firstDot, int lastDot, int y, char symbol)
        {
            for(int i = firstDot; i <= lastDot; i++)
            {
                dotList.Add(new Dot(i, y, symbol));
            }
        }
    }
}
