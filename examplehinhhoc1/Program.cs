
using System;

namespace Shape
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

    // ===== Lớp Circle kế thừa Shape =====
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

        public double GetRadius()
        {
            return Radius;
        }

        public void SetRadius(double radius)
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

    // ===== Lớp ComparableCircle triển khai IComparable =====
    public class ComparableCircle : Circle, IComparable<ComparableCircle>
    {
        public ComparableCircle() : base() { }
        public ComparableCircle(double radius) : base(radius) { }
        public ComparableCircle(double radius, string color, bool filled) : base(radius, color, filled) { }

        public int CompareTo(ComparableCircle other)
        {
            if (other == null) return 1;

            if (GetRadius() > other.GetRadius()) return 1;
            else if (GetRadius() < other.GetRadius()) return -1;
            else return 0;
        }
    }

    // ===== Chương trình kiểm thử =====
    class Program
    {
        static void Main(string[] args)
        {
            ComparableCircle[] circles = new ComparableCircle[3];
            circles[0] = new ComparableCircle(3.6);
            circles[1] = new ComparableCircle();
            circles[2] = new ComparableCircle(3.5, "indigo", false);

            Console.WriteLine("Pre-sorted:");
            foreach (ComparableCircle circle in circles)
            {
                Console.WriteLine(circle);
            }

            Array.Sort(circles);

            Console.WriteLine("\nAfter-sorted:");
            foreach (ComparableCircle circle in circles)
            {
                Console.WriteLine(circle);
            }

            Console.ReadLine();
        }
    }
}
