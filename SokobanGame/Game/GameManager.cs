using System;

namespace SokobanGame
{
    // 게임의 핵심 로직을 관리하고 실행하는 관리자 클래스.
    public class GameManager
    {
        // 필드.
        // 점수 관련 필드.
        private int currentScore = 0;
        private int targetScore = 0;

        // 게임이 클리어 됐는지 확인하는 프로퍼티.
        public bool IsGameClear
        {
            get
            {
                return currentScore == targetScore;
            }
        }

        // 생성자 - 관리자 객체를 생성할 때 이 스테이지에서 획득해야하는 점수를 전달.
        public GameManager(int targetscore)
        {
            this.targetScore = targetscore;
            currentScore = 0;
        }

        // 이동이 가능한지 판단할 때 사용할 메소드(인터페이스).
        /* 
        - 플레이어가 이동할 때 이동이 가능한지 판단
            - 이동하려는 위치에 박스가 있는가?
            - 이동하려는 위치에 벽이 있는가?
            - 이동하려는 위치가 길이거나 타겟인가?
        - 플레이어가 박스를 미는 기능 처리
            - 플레이어가 이동하려는 위치가 박스가 있는가?
            - 있다면, 박스가 이동하려는 위치가 이동 가능한 위치인가?
        - 스테이지가 클리어됐는지 판단
            - 박스와 타겟의 위치가 겹쳤는지로 판단.
            - 박스와 타겟이 겹친 수가 같은지 판단 -> 스테이지 클리어. 
         */

        /// <summary>
        /// 이동이 가능한지 판단할 때 사용할 메소드(인터페이스).
        /// </summary>
        /// <param name="newPosition">이동하려는 위치</param>
        /// <param name="player">플레이어</param>
        /// <param name="gameObjects">레벨에 배치된 기본 게임 오브젝트 리스트</param>
        /// <param name="boxes">레벨에 배치된 박스 게임 오브젝트 리스트</param>
        /// <param name="targets">레벨에 배치된 타겟 게임 오브젝트 리스트</param>
        public bool CanMove(
            Point newPosition,
            Player player,
            List<GameObject> gameObjects,
            List<Box> boxes,
            List<Target> targets)
        {
            // 예외 처리.
            if (gameObjects == null || gameObjects.Count == 0)
            {
                return false;
            }

            // 이동하려는 위치에 박스가 있는 경우.
            Box searchBox = null;
            foreach (var box in  boxes)
            {
                // 이동하려는 위치에 박스가 있는지 검색.
                if (box.position.Equals(newPosition) == true)
                {
                    // 검색에 성공했다면, 참조를 저장하고, 루프 종료.
                    searchBox = box;
                    break;
                }
            }

            // 박스가 있는 경우의 처리.
            if (searchBox != null)
            {
                // 이동 방향 구하기 = 가려는 위치 - 현재 위치.
                Point direction = new Point();
                direction.x = newPosition.x - player.position.x;
                direction.y = newPosition.y - player.position.y;

                // 박스가 이동해야하는 위치 = 이동 방향 + 박스의 위치.
                Point newBoxPosition = new Point(
                    direction.x + searchBox.position.x,
                    direction.y + searchBox.position.y
                );

                // 박스가 이동하려는 곳이 이동이 가능한가?
                // Target이거나 Ground라면 이동이 가능함.
                // 이 둘이 아니라면(Wall이거나 Box라면) 이동 불가.

                // 박스가 이동하려는 위치에 다른 박스가 있는지 확인.
                Box anotherBox = null;
                foreach (var box in boxes)
                {
                    if (box.position.Equals(newBoxPosition) == true)
                    {
                        // 검색이 됐다면, 값 저장하고 루프 종료.
                        anotherBox = box;
                        break;
                    }
                }

                // 박스가 검색됐다면 이동 불가.
                if (anotherBox != null)
                {
                    return false;
                }

                GameObject finalFound = null;
                foreach (var go in gameObjects)
                {
                    if (go.position.Equals(newBoxPosition) == true)
                    {
                        finalFound = go;
                        break;
                    }
                }

                // 검색이 됐는지 확인.
                if (finalFound != null)
                {
                    if (finalFound is Ground || finalFound is Target)
                    {
                        // 박스를 이동.
                        searchBox.SetPosition(newBoxPosition);

                        // Todo: 점수 업데이트.
                        UpdateScore(boxes, targets);

                        return true;
                    }
                }

                //벽이기 때문에 이동 불가.
                return false;
            }

            // 이동이 가능한 경우.
            GameObject searchObject = gameObjects.Find(
                go => go.position.Equals(newPosition)
            );



            //// 검색.
            //foreach (GameObject go in gameObjects)
            //{
            //    // 이동하려는 위치에 있는 게임 오브젝트 검색.
            //    if (go.position.Equals(newPosition) == true)
            //    {
            //        searchObject = go;
            //        break;
            //    }
            //}

            // 위의 검색 과정에서 게임 오브젝트를 찾은 경우.
            if (searchObject != null)
            {
                //return (searchObject is Wall) == false;
                return (searchObject is Ground || searchObject is Target);
            }

            return false;
        }
        // 점수 업데이트 (점수 확인) 메소드.
        private void UpdateScore(List<Box> boxes, List<Target> targets)
        {
            // 전부 리셋하고 처음부터 다시 계산.
            currentScore = 0;
            foreach (var box in boxes)
            {
                foreach (var target in targets)
                {
                    // 두 물체가 겹쳐있는지 확인.
                    // 겹쳤으면 1점씩 증가 처리.
                    if (box.position.Equals(target.position) == true)
                    {
                        ++currentScore;

                        // 점수 증가 처리 후 루프 건너뛰기
                        continue;
                    }
                }
            }
        }
    
    }
}