using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    //This class used for building vertical lines
    class VerticalLine : Figure
    {
        public VerticalLine(int firstDot, int lastDot, int x, char symbol)
        {
            dotList = new List<Dot>();

            for(int i = firstDot; i <= lastDot; i++)
            {
                dotList.Add(new Dot(x, i, symbol));
            }
        }
    }
}
