using System;

// Abstract base
abstract class Shape
{
    public abstract double GetArea();
}

// Circle
class Circle : Shape
{
    public double Radius { get; }
    public Circle(double radius) => Radius = radius;
    public override double GetArea()
        => Math.PI * Radius * Radius;
}

// Rectangle
class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }
    public Rectangle(double w, double h)
    {
        Width = w;
        Height = h;
    }
    public override double GetArea()
        => Width * Height;
}

class Program
{
    static void Main()
    {
        Console.Write("Enter circle radius: ");
        double r = double.Parse(Console.ReadLine()!);
        var circle = new Circle(r);
        Console.WriteLine($"Circle area: {circle.GetArea():F2}");

        Console.Write("Enter rectangle width: ");
        double w = double.Parse(Console.ReadLine()!);
        Console.Write("Enter rectangle height: ");
        double h = double.Parse(Console.ReadLine()!);
        var rect = new Rectangle(w, h);
        Console.WriteLine($"Rectangle area: {rect.GetArea():F2}");
    }
}
