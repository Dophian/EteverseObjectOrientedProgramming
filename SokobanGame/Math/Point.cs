using System;

namespace SokobanGame
{
    public class Point
    {
        // 필드.
        public int x { get; set; } = 0;
        public int y { get; set; } = 0;

        // 생성자.
        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // 같은지 비교 함수.
        public override bool Equals(object? obj)
        {
            // 현재 Point의 x와 y가 함수로 전달된 obj의 x와 x 값과 같은지 비교.
            // 비교를 위해서 obj를 Point로 형변환.
            Point? other = obj as Point;
            //Point? other = (Point)obj;

            // 형변환 실패 → obj가 Point 타입이 아니하면 비교가 불가능.
            if (other == null)
            {
                return false;
            }
            
            // x와 y가 같은지 비교.
            return x == other.x && y == other.y;
        }

    }
}