using System;

public class Shape
{
    private string color = "green";
    private bool filled = true;

    public Shape() { }

    public Shape(string color, bool filled)
    {
        this.color = color;
        this.filled = filled;
    }

    public string GetColor()
    {
        return color;
    }

    public void SetColor(string color)
    {
        this.color = color;
    }

    public bool IsFilled()
    {
        return filled;
    }

    public void SetFilled(bool filled)
    {
        this.filled = filled;
    }

    public override string ToString()
    {
        return "A Shape with color of " + GetColor()
               + " and " + (IsFilled() ? "filled" : "not filled");
    }
}

public class Circle : Shape
{
    private double radius = 1.0;

    public Circle() { }

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public Circle(double radius, string color, bool filled)
        : base(color, filled)
    {
        this.radius = radius;
    }

    public double GetRadius()
    {
        return radius;
    }

    public void SetRadius(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        return radius * radius * Math.PI;
    }

    public double GetPerimeter()
    {
        return 2 * radius * Math.PI;
    }

    public override string ToString()
    {
        return "A Circle with radius=" + GetRadius()
               + ", which is a subclass of " + base.ToString();
    }
}

public class Rectangle : Shape
{
    private double width = 1.0;
    private double length = 1.0;

    public Rectangle() { }

    public Rectangle(double width, double length)
    {
        this.width = width;
        this.length = length;
    }

    public Rectangle(double width, double length, string color, bool filled)
        : base(color, filled)
    {
        this.width = width;
        this.length = length;
    }

    public double GetWidth()
    {
        return width;
    }

    public virtual void SetWidth(double width)
    {
        this.width = width;
    }

    public double GetLength()
    {
        return length;
    }

    public virtual void SetLength(double length)
    {
        this.length = length;
    }

    public double GetArea()
    {
        return width * length;
    }

    public double GetPerimeter()
    {
        return 2 * (width + length);
    }

    public override string ToString()
    {
        return "A Rectangle with width=" + GetWidth()
               + " and length=" + GetLength()
               + ", which is a subclass of " + base.ToString();
    }
}

public class Square : Rectangle
{
    public Square() { }

    public Square(double side) : base(side, side) { }

    public Square(double side, string color, bool filled)
        : base(side, side, color, filled) { }

    public double GetSide()
    {
        return GetWidth();
    }

    public void SetSide(double side)
    {
        base.SetWidth(side);
        base.SetLength(side);
    }

    public override void SetWidth(double width)
    {
        SetSide(width);
    }

    public override void SetLength(double length)
    {
        SetSide(length);
    }

    public override string ToString()
    {
        return "A Square with side=" + GetSide()
               + ", which is a subclass of " + base.ToString();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Test Shape ===");
        Shape shape = new Shape();
        Console.WriteLine(shape);
        shape = new Shape("red", false);
        Console.WriteLine(shape);

        Console.WriteLine("\n=== Test Circle ===");
        Circle circle = new Circle();
        Console.WriteLine(circle);
        circle = new Circle(3.5);
        Console.WriteLine(circle);
        circle = new Circle(3.5, "indigo", false);
        Console.WriteLine(circle);
        Console.WriteLine("Area: " + circle.GetArea());
        Console.WriteLine("Perimeter: " + circle.GetPerimeter());

        Console.WriteLine("\n=== Test Rectangle ===");
        Rectangle rectangle = new Rectangle();
        Console.WriteLine(rectangle);
        rectangle = new Rectangle(2.3, 5.8);
        Console.WriteLine(rectangle);
        rectangle = new Rectangle(2.5, 3.8, "orange", true);
        Console.WriteLine(rectangle);
        Console.WriteLine("Area: " + rectangle.GetArea());
        Console.WriteLine("Perimeter: " + rectangle.GetPerimeter());

        Console.WriteLine("\n=== Test Square ===");
        Square square = new Square();
        Console.WriteLine(square);
        square = new Square(2.3);
        Console.WriteLine(square);
        square = new Square(5.8, "yellow", true);
        Console.WriteLine(square);
        square.SetSide(4.0);
        Console.WriteLine("After SetSide(4.0): " + square);
        Console.WriteLine("Area: " + square.GetArea());
        Console.WriteLine("Perimeter: " + square.GetPerimeter());
    }
}
