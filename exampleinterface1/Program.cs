using System;

namespace ResizeableShapes
{
    // Interface yêu cầu các lớp triển khai phương thức Resize
    public interface IResizeable
    {
        void Resize(double percent);
    }

    // Lớp trừu tượng Shape (cha của tất cả các hình)
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    // Lớp Circle
    public class Circle : Shape, IResizeable
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public void Resize(double percent)
        {
            Radius += Radius * percent / 100;
        }

        public override string ToString()
        {
            return $"Circle (radius = {Radius:F2})";
        }
    }

    // Lớp Rectangle
    public class Rectangle : Shape, IResizeable
    {
        public double Width { get; protected set; }
        public double Height { get; protected set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public virtual void Resize(double percent)
        {
            Width += Width * percent / 100;
            Height += Height * percent / 100;
        }

        public override string ToString()
        {
            return $"Rectangle (width = {Width:F2}, height = {Height:F2})";
        }
    }

    // Lớp Square kế thừa Rectangle
    public class Square : Rectangle
    {
        public Square(double side) : base(side, side) { }

        public override void Resize(double percent)
        {
            Width += Width * percent / 100;
            Height = Width; // đảm bảo vẫn là hình vuông
        }

        public override string ToString()
        {
            return $"Square (side = {Width:F2})";
        }
    }

    // Chương trình test
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            IResizeable[] shapes =
            {
                new Circle(5),
                new Rectangle(4, 6),
                new Square(3)
            };

            foreach (var shape in shapes)
            {
                Shape s = (Shape)shape;

                double oldArea = s.GetArea();
                double percent = random.Next(1, 101);

                shape.Resize(percent);

                double newArea = s.GetArea();

                Console.WriteLine($"{s}");
                Console.WriteLine($"Tăng kích thước: {percent}%");
                Console.WriteLine($"Diện tích trước: {oldArea:F2}");
                Console.WriteLine($"Diện tích sau  : {newArea:F2}");
                Console.WriteLine(new string('-', 40));
            }

            Console.ReadLine();
        }
    }
}
