using System;

namespace SokobanGame
{
    public class Target : GameObject
    {
        public Target()
        {
            color = ConsoleColor.Blue;
        }
        public override void Update(ConsoleKey key)
        {

        }
        public override void Draw()
        {
            Console.ForegroundColor = color;
            Console.Write('□');
        }
    }
}
