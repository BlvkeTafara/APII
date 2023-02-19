using System;
public interface IDrawable
{
    void draw();
}
public class Rectangle : IDrawable
{
    public void draw()
    {
        Console.WriteLine("Drawing Rectangle...");
    }
}
public class Circle : IDrawable
{
    public void draw()
    {
        Console.WriteLine("Drawing Circle...");
    }
}
public class Test
{
    public static void main()
    {
        IDrawable d;
        d = new Rectangle();
        d.draw();
        d = new Circle();
        d.draw();

    }
}

