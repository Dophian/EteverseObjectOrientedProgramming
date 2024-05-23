using System;

namespace SokobanGame
{
    // 씬(장면, 레벨) - 스테이지를 읽고 관리하는 클래스.
    public class Scene
    {
        // 그릴 때 깊이(Depth) 조정을 위해 카테고리 별로 분리.
        private List<GameObject> gameObjects = new List<GameObject>();

        // 박스 게임오브젝트.
        private List<Box> boxes = new List<Box>();

        // 타겟 게임오브젝트 -> 그릴 때는 사용하지 않고, 점수 확인할 때 사용.
        private List<Target> targets = new List<Target>();

        // 플레이어 게임 오브젝트.
        private Player player;

        // 게임 관리자 객체.
        private GameManager gameManager;

        public Scene(string mapFilename)
        {
            // 레벨 로드.
            Load(mapFilename);

            // 게임 관리자 객체 생성.
            gameManager = new GameManager(targets.Count);
        }

        // 이동이 가능한지 판단할 때 사용할 메소드.
        public bool CanMove(Point newPosition)
        {
            // 게임 관리자 객체에 필요한 값들을 전달해서 이동이 가능한지의 판단을 위임.
            return gameManager.CanMove(
                newPosition,
                player,
                gameObjects,
                boxes,
                targets
            );
        }

        // 맵 파일을 읽고 분석하는 메소드.
        private void Load(string filename)
        {
            // 맵 파일을 전체 문자열로 읽어서 저장.
            //gameObjects = File.ReadAllText(filename);
            //gameObjects = File.ReadAllLines(filename);
            string[] lines = File.ReadAllLines(filename);

            // 한 줄씩 저장된 리스트의 문자열을 루프로 처리.
            //foreach (string line in lines)
            for (int y = 0; y < lines.Length; ++y)
            {
                // 한줄에 해당하는 문자열을 문자 배열로 변환.
                char[] lineChars = lines[y].ToCharArray();

                // 문자 배열의 각 문자 값을 mapdata 리스트에 추가.
                //foreach (char c in lineChars)
                for (int x = 0; x < lineChars.Length; ++x)
                {
                    char c = lineChars[x];

                    // 게임 오브젝트가 생성될 위치.
                    Point position = new Point(x, y);

                    // 문자 값이 1이면 벽(Wall).
                    if (c == '1')
                    {
                        gameObjects.Add(new Wall(position));
                    }

                    // 문자 값이 .이면 땅(Ground) - 이동할 수 있는 위치.
                    else if (c == '.')
                    {
                        gameObjects.Add(new Ground(position));
                    }

                    // 문자 값이 p이면 플레이어(Player).
                    else if (c == 'p')
                    {
                        // 플레이어 생성.
                        player = new Player(position, this);

                        // 플레이어의 위치는 길도 같이 생성해줘야 함.
                        // 나중에 플레이어가 이동했을 때 길이 그려질 수 있도록.
                        gameObjects.Add(new Ground(position));
                    }

                    // 문자 값이 t이면 타겟(Target).
                    else if (c == 't')
                    {
                        // 타겟 게임 오브젝트 생성.
                        Target newTarget = new Target(position);
                        gameObjects.Add(newTarget);

                        // 점수 확인을 위해서 타겟을 따로 또 관리.
                        targets.Add(newTarget);
                    }

                    // 문자 값이 b이면 박스(Box).
                    else if (c == 'b')
                    {
                        // 박스는 따로 그릴 수 있도록 처리.
                        boxes.Add(new Box(position));

                        // 박스의 위치는 길도 같이 생성해줘야 함.
                        // 나중에 박스가 이동했을 때 길이 그려질 수 있도록.
                        gameObjects.Add(new Ground(position));
                    }
                }
            }
        }

        // Update 메소드(인터페이스).
        public void Update(ConsoleKey key)
        {
            //// 물체 업데이트 처리.
            //foreach (var gameObject in gameObjects)
            //{
            //    gameObject.Update(key);
            //}

            // 게임이 클리어 됐는지 확인하고, 클리어라면 업데이트 진행 안함.
            if (gameManager.IsGameClear == true)
            {
                return;
            }

            // 플레이어 업데이트.
            player.Update(key);
        }

        // Draw 메소드(인터페이스).
        public void Draw()
        {
            // 레벨 그리기.
            // 가장 먼저 그려져야 할 물체 그리기.
            foreach (var gameObject in gameObjects)
            {
                gameObject.Draw();
            }

            // 박스 그리기.
            foreach (var box in boxes)
            {
                box.Draw();
            }

            // 플레이어 그리기.
            player.Draw();
            
            // 메뉴 그리기.
            DrawMenue();

            // 게임 클리어인 경우, 화면에 메세지 출력.
            if (gameManager.IsGameClear == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(15, 1);
                Console.Write("게임 클리어!");
            }
        }

        private void DrawMenue()
        {
            // 메뉴 그리기.
            Console.ForegroundColor = ConsoleColor.White;

            // x로 15칸, y로는 0칸 커서 이동.
            Console.SetCursorPosition(15, 0);

            // 메뉴 문자 출력.
            Console.WriteLine("게임을 종료하려면 Q키[또는 ESC키를 누르시요.");
        }
    }
}