using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class GameField
    {
        private static int scoreFactor;
        private static int gameScore;
        string playerName;
        public Line[] fence = new Line[4];
        public Line[] barrier;

        public static int gameScoreProperty
        {
            get
            {
                return gameScore;
            }

            set
            {
                gameScore += value * scoreFactor;
            }
        }

        public GameField()
        {
            scoreFactor = 10;

            Console.SetBufferSize(80, 25);

            GetPlayerName();

            fence[0] = new Line(0, 79, 0, HorizontalVertical.HORIZONTAL, '+');
            fence[1] = new Line(0, 79, 23, HorizontalVertical.HORIZONTAL, '+');
            fence[2] = new Line(0, 23, 0, HorizontalVertical.VERTICAL, '+');
            fence[3] = new Line(0, 23, 79, HorizontalVertical.VERTICAL, '+');

            barrier = new Line[] { new Line(0, 23, 0, HorizontalVertical.VERTICAL, '+') };

            foreach (Line line in fence)
                line.Draw();
        }

        public void GetPlayerName() 
        {
            Console.SetCursorPosition(31, 8);
            Console.WriteLine("Enter your name");

            Console.SetCursorPosition(39, 10);
            playerName = Console.ReadLine();

            if (String.IsNullOrEmpty(playerName) || String.IsNullOrWhiteSpace(playerName))
            {
                playerName = "Unknown player";
            }

            if(playerName.Length >= 15)
            {
                playerName = playerName.Substring(0, 10);
            }

            Console.Clear();
        }

        public void GetResults()
        {
            Console.Clear();
            Console.SetCursorPosition(34, 5);
            Console.WriteLine("GAME OVER");

            Console.SetCursorPosition(36, 6);
            Console.WriteLine("score");

            int namePosition = ((playerName.Length % 2) >= 1) ? 
                38 - playerName.Length / 2 : 
                38 - playerName.Length / 2;

            Console.SetCursorPosition(namePosition, 8);
            Console.WriteLine(playerName);
            Console.SetCursorPosition(38, 9);
            Console.WriteLine(gameScore);
        }

        public static void PrintGameScore()
        {
            Console.SetCursorPosition(0, 24);
            Console.Write("Your score : {0}", gameScore);
        }
    }
}
