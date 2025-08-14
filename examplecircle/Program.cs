using System;

public class Circle
{
    private double radius = 1.0;
    private string color = "red";

    public Circle() { }

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public Circle(double radius, string color)
    {
        this.radius = radius;
        this.color = color;
    }

    public double GetRadius()
    {
        return radius;
    }

    public void SetRadius(double radius)
    {
        this.radius = radius;
    }

    public string GetColor()
    {
        return color;
    }

    public void SetColor(string color)
    {
        this.color = color;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }

    public override string ToString()
    {
        return $"Circle [radius={radius}, color={color}, area={GetArea():F2}]";
    }
}

public class Cylinder : Circle
{
    private double height = 1.0;

    public Cylinder() { }

    public Cylinder(double height)
    {
        this.height = height;
    }

    public Cylinder(double height, double radius)
        : base(radius)
    {
        this.height = height;
    }

    public Cylinder(double height, double radius, string color)
        : base(radius, color)
    {
        this.height = height;
    }

    public double GetHeight()
    {
        return height;
    }

    public void SetHeight(double height)
    {
        this.height = height;
    }

    public double GetVolume()
    {
        return GetArea() * height;
    }

    public override string ToString()
    {
        return $"Cylinder [radius={GetRadius()}, color={GetColor()}, height={height}, volume={GetVolume():F2}]";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Test Circle ===");
        Circle c1 = new Circle();
        Console.WriteLine(c1);
        Circle c2 = new Circle(2.5);
        Console.WriteLine(c2);
        Circle c3 = new Circle(3.0, "blue");
        Console.WriteLine(c3);

        Console.WriteLine("\n=== Test Cylinder ===");
        Cylinder cy1 = new Cylinder();
        Console.WriteLine(cy1);
        Cylinder cy2 = new Cylinder(5.0);
        Console.WriteLine(cy2);
        Cylinder cy3 = new Cylinder(10.0, 3.0);
        Console.WriteLine(cy3);
        Cylinder cy4 = new Cylinder(7.0, 2.5, "green");
        Console.WriteLine(cy4);
    }
}

