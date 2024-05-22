using System;

namespace SokobanGame
{
    public class Box : GameObject
    {
        public Box()
        {
            color = ConsoleColor.Cyan;
        }
        public override void Update(ConsoleKey key)
        {

        }
        public override void Draw()
        {
            Console.ForegroundColor = color;
            Console.Write('■');
        }
    }
}
