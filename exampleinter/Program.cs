
using System;

namespace ShapeColorable
{
    // ===== Lớp trừu tượng Shape =====
    public abstract class Shape
    {
        public string Color { get; set; }
        public bool Filled { get; set; }

        public Shape()
        {
            Color = "green";
            Filled = true;
        }

        public Shape(string color, bool filled)
        {
            Color = color;
            Filled = filled;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"A Shape with color of {Color} and {(Filled ? "filled" : "not filled")}";
        }
    }

    // ===== Lớp Circle =====
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 1.0;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public Circle(double radius, string color, bool filled) : base(color, filled)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return $"A Circle with radius = {Radius:F2}, which is a subclass of {base.ToString()}";
        }
    }

    // ===== Lớp Rectangle =====
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
            Width = 1.0;
            Height = 1.0;
        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public Rectangle(double width, double height, string color, bool filled) : base(color, filled)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }

        public override string ToString()
        {
            return $"A Rectangle with width = {Width:F2} and height = {Height:F2}, which is a subclass of {base.ToString()}";
        }
    }

    // ===== Bước 2: Interface IColorable =====
    public interface IColorable
    {
        void HowToColor();
    }

    // ===== Lớp Square triển khai IColorable =====
    public class Square : Rectangle, IColorable
    {
        public Square()
        {
            Width = Height = 1.0;
        }

        public Square(double side) : base(side, side)
        {
        }

        public Square(double side, string color, bool filled) : base(side, side, color, filled)
        {
        }

        public override string ToString()
        {
            return $"A Square with side = {Width:F2}, which is a subclass of {base.ToString()}";
        }

        public void HowToColor()
        {
            Console.WriteLine("Color all four sides.");
        }
    }

    // ===== Chương trình kiểm thử =====
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Circle(3.5, "red", true);
            shapes[1] = new Rectangle(2.0, 4.0, "blue", false);
            shapes[2] = new Square(5.0, "yellow", true);

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
                Console.WriteLine($"Area: {shape.GetArea():F2}");

                if (shape is IColorable colorableShape)
                {
                    colorableShape.HowToColor();
                }

                Console.WriteLine(new string('-', 40));
            }

            Console.ReadLine();
        }
    }
}
