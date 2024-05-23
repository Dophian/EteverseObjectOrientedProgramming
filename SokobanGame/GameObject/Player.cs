using System;

namespace SokobanGame
{
    public class Player : GameObject
    {
        // 필드
        // 씬 객체: 플레이어가 이동을 시도할 때 이동이 가능한지 판단하기 위해 사용.
        private Scene scene;

        public Player(Point position, Scene scene) : base(position)
        {
            // 씬 객체 참조 저장.
            this.scene = scene;
            color = ConsoleColor.Magenta;
            name = 'P';
        }

        // 업데이트
        public override void Update(ConsoleKey key)
        {
            //임시
            //Console.Clear();

            switch (key)
            {   // 왼쪽으로 이동 처리.
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:

                    // 이동이 가능한지 확인.
                    if (scene.CanMove(new Point(position.x -1, position.y)))
                    {
                        // 왼쪽으로의 이동은 x좌표를 하나 감소시키는 것과 같음.
                        position.x = position.x - 1;
                    }

                    break;

                // 오른쪽으로의 이동 처리.
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:

                    if (scene.CanMove(new Point(position.x + 1, position.y)))
                    {
                        // 오른쪽으로의 이동은 x좌표를 하나 증가시키는 것과 같음.
                        position.x = position.x + 1;
                    }
                    break;

                // 위쪽으로의 이동 처리.
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:

                    if (scene.CanMove(new Point(position.x, position.y - 1)))
                    {
                        // 위쪽으로의 이동은 y좌표를 하나 감소시키는 것과 같음.
                        position.y = position.y - 1;
                    }
                    break;

                // 아래쪽으로의 이동 처리.
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:

                    if (scene.CanMove(new Point(position.x, position.y + 1)))
                    {
                        // 아래쪽으로의 이동은 y좌표를 하나 증가시키는 것과 같음.
                        position.y = position.y + 1;
                    }
                    break;
            }   
        }
    }
}
