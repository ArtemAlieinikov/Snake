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
            Console.SetBufferSize(80, 25);
            HorisontalLine topLine = new HorisontalLine(0, 79, 0, '+');
            HorisontalLine bottomLine = new HorisontalLine(0, 79, 23, '+');
            VerticalLine rightLine = new VerticalLine(0, 23, 0, '+');
            VerticalLine leftLine = new VerticalLine(0, 23, 79, '+');

            leftLine.Draw();
            rightLine.Draw();
            topLine.Draw();
            bottomLine.Draw();

            Console.ReadLine();
        }
    }
}
