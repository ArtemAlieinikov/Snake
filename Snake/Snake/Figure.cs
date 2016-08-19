﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    //Base class for Lines and Snake
    class Figure
    {
        protected List<Dot> dotList;

        public void Draw()
        {
            foreach(Dot currentDot in dotList)
            {
                currentDot.Draw();
            }
        }
    }
}