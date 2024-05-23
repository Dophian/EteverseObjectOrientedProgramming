﻿using System;

namespace SokobanGame
{
    public class Ground : GameObject
    {
        public Ground(Point position) : base(position)
        {
            color = ConsoleColor.Black;
            name = '_';
        } 
    }
}
