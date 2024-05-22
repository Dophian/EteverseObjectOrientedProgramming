using System;

namespace SokobanGame
{
    // 씬(장면, 레벨) - 스테이지를 읽고 관리하는 클래스.
    public class Scene
    {
        //private List<char> mapData = new List<char>();
        private List<GameObject> mapData = new List<GameObject>();

        public Scene(string mapFilename)
        {
            Load(mapFilename);
        }

        // 맵 파일을 읽고 분석하는 메소드.
        private void Load(string filename)
        {
            // 맵 파일을 전체 문자열로 읽어서 저장.
            //mapData = File.ReadAllText(filename);
            //mapData = File.ReadAllLines(filename);
            string[] lines = File.ReadAllLines(filename);

            // 한 줄씩 저장된 리스트의 문자열을 루프로 처리.
            foreach (string line in lines)
            {
                // 한줄에 해당하는 문자열을 문자 배열로 변환.
                char[] lineChars = line.ToCharArray();

                // 문자 배열의 각 문자 값을 mapdata 리스트에 추가.
                foreach (char c in lineChars)
                {
                    // 문자 값이 1이면 벽(Wall).
                    if (c == '1')
                    {
                        mapData.Add(new Wall());
                        //mapData.Add('■');
                    }

                    // 문자 값이 .이면 땅(Ground) - 이동할 수 있는 위치.
                    else if (c == '.')
                    {
                        mapData.Add(new Ground());
                        //mapData.Add('□');
                    }

                    // 문자 값이 p이면 플레이어(Player).
                    else if (c == 'p')
                    {
                        mapData.Add(new Player());
                        //mapData.Add('●');
                    }

                    // 문자 값이 t이면 타겟(Target).
                    else if (c == 't')
                    {
                        mapData.Add(new Target());
                        //mapData.Add('◇');
                    }

                    // 문자 값이 b이면 박스(Box).
                    else if (c == 'b')
                    {
                        mapData.Add(new Box());
                        //mapData.Add('◆');
                    }

                    //else
                    //{
                    //    mapData.Add(c);
                    //}
                }

                // 엔터 값(개행 문자) 추가.
                //mapData.Add('\n');
            }
        }

        // Update 메소드(인터페이스).
        public void Update(ConsoleKey key)
        {
            foreach (var gameObject in mapData)
            {
                gameObject.Update(key);
            }

        }

        // Draw 메소드(인터페이스).
        public void Draw()
        {
            //Console.WriteLine(mapData);
            int index = 0;
            foreach (var gameObject in mapData)
            {
                //Console.Write(line);
                gameObject.Draw();
                
                // 한줄을 그린 뒤에 /n을 추가해야하는지 확인.
                index++;
                if (index % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}