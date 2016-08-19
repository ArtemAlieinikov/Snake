using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Dot dot1 = new Dot(10,15,'*');
            dot1.Draw();

            Dot dot2 = new Dot(5, 25, '*');
            dot2.Draw();
        }
    }
}
