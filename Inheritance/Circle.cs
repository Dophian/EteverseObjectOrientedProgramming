using System;

public class Circle : Point
{
    private float radius;
    private const float PI = 3.1415926535f;

    public Circle(float x, float y, float radius)
    {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }

    public override void ShowData()
    {
        base.ShowData();

        Console.WriteLine($"반지름: {radius}");
        Console.WriteLine($"원의 넓이: {PI * radius * radius}");
    }
}