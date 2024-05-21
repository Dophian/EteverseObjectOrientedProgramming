using System;

// x, y 좌표를 나타내는 위치 클래스.
public class Point
{
    // 필드.
    private int x;
    private int y;

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

    // 출력에 용이하도록 ToString 오버라이드.
    public override string ToString()
    {
        return $"({x}, {y})";
    }
}