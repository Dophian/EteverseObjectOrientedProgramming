using System;

public class Point
{
    protected float x;
    protected float y;

    public virtual void ShowData()
    {
        Console.WriteLine($"중심 좌표: [{x}, {y}]");
    }
}