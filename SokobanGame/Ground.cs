using System;

namespace SokobanGame
{
    public class Ground : GameObject
    {
        public Ground()
        {
            color = ConsoleColor.Black;
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
