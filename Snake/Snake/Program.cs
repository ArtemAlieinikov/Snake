using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            GameField myGameField = new GameField();

            Dot snakeTail = new Dot(39, 20, '*');
            Snake mySnake = new Snake(snakeTail, 3, Direction.UP, 100);

            FoodCreator foodCreator = new FoodCreator(80, 25, '@');
            Dot food = foodCreator.CreateFood(mySnake);

            mySnake.Draw();
            food.Draw();

            Thread.Sleep(1000);

            while(true)
            {

                mySnake.Move();
                GameField.PrintGameScore();

                if (mySnake.IsCollision(myGameField))
                {
                    myGameField.GetResults();
                    Console.SetCursorPosition(0, 24);
                    break;
                }

                if(mySnake.IsEating(food))
                {
                    GameField.gameScoreProperty = 1;
                    food = foodCreator.CreateFood(mySnake);
                    food.Draw();
                }

                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    mySnake.KeyPushReaction(key.Key);
                }
            }

            Console.ReadLine();
        }
    }
}
