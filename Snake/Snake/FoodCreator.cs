using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator : Dot
    {
        Random rand = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char symbol) 
            : base(mapWidth, mapHeight, symbol)
        { }

        public Dot CreateFood()
        {
            int rX = rand.Next(2, x - 2);
            int rY = rand.Next(2, y - 2);
            return new Dot(rX, rY, symbol);
        }
    }
}
