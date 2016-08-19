using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorisontalLine : Figure
    {
        public HorisontalLine(int firstDot, int lastDot, int y, char symbol)
        {
            dotList = new List<Dot>();

            for(int i = firstDot; i <= lastDot; i++)
            {
                dotList.Add(new Dot(i, y, symbol));
            }
        }
    }
}
