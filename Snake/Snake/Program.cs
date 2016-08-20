using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            Dot snakeTail = new Dot(10, 12, '*');
            Snake mySnake = new Snake(snakeTail, 1, Direction.RIGHT);
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Dot food = foodCreator.CreateFood();

            food.Draw();
            mySnake.Draw();

            while(true)
            {
                mySnake.Move();
                Thread.Sleep(1000);

                if(mySnake.IsEat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }

                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    mySnake.KeyPushReaction(key.Key);
                }
            }
        }
    }
}
