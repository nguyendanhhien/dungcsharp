using System;
using System.Collections.Generic;

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

    // ===== Bước 1: Lớp CircleComparator triển khai IComparer =====
    public class CircleComparator : IComparer<Circle>
    {
        public int Compare(Circle c1, Circle c2)
        {
            if (c1 == null && c2 == null) return 0;
            if (c1 == null) return -1;
            if (c2 == null) return 1;

            if (c1.GetRadius() > c2.GetRadius()) return 1;
            else if (c1.GetRadius() < c2.GetRadius()) return -1;
            else return 0;
        }
    }

    // ===== Bước 2: Chương trình kiểm thử =====
    class Program
    {
        static void Main(string[] args)
        {
            Circle[] circles = new Circle[3];
            circles[0] = new Circle(3.6);
            circles[1] = new Circle();
            circles[2] = new Circle(3.5, "indigo", false);

            Console.WriteLine("Pre-sorted:");
            foreach (Circle circle in circles)
            {
                Console.WriteLine(circle);
            }

            IComparer<Circle> circleComparator = new CircleComparator();
            Array.Sort(circles, circleComparator);

            Console.WriteLine("\nAfter-sorted:");
            foreach (Circle circle in circles)
            {
                Console.WriteLine(circle);
            }

            Console.ReadLine();
        }
    }
}
