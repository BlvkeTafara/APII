using System;
public interface IDrawable
{
    void Draw();
}
public class Rectangle : IDrawable
{
    public void Draw()//capitalise
    {
        Console.WriteLine("Drawing Rectangle...");
    }
}
public class Circle : IDrawable
{
    public void Draw() //capitalise
    {
        Console.WriteLine("Drawing Circle...");
    }
}
public static class Test //static methods must be used in static classes only 
{ 
    public static void Main(string[] args) // by convection method names are capitalized
    {
        IDrawable d;
        d = new Rectangle();//good
        d.Draw();
        d = new Circle();//bho zvekuti
        d.Draw();

        //good
    }
}

