using System;
using System.Xml.Linq;

public class Rectangle
{
    private float area;
    private float size;

    public Rectangle(float area, float size)
    {
        this.area = area;
        this.size = size;
    }

    public float GetArea()
    {
        return area;
    }

    public float GetSize()
    {
        return size;
    }

    public void SetArea(float area)
    {
        if (area < 0)
        {
            throw new ArgumentException("면적은 양수여야 합니다.");
        }
        else
        {
            this.area = area;
        }


    }

    public void SetSize(float size)
    {
        if (size < 0)
        {
            throw new ArgumentException("둘레는 양수여야 합니다.");
        }
        else
        {
            this.size = size;
        }
    }
    public void PrintData()
    {
        Console.WriteLine($"면적: {area} | 둘레: {size}");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(3f, 4f);    // 가로, 세로 길이 전달.
            Console.WriteLine($"면적: {rectangle.GetArea()}");
            Console.WriteLine($"둘레: {rectangle.GetSize()}");

        }


    }
}