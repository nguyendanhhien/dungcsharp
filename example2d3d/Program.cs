using System;

public class Point2D
{
    private float x = 0.0f;
    private float y = 0.0f;

    public Point2D() { }

    public Point2D(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public float GetX()
    {
        return x;
    }

    public void SetX(float x)
    {
        this.x = x;
    }

    public float GetY()
    {
        return y;
    }

    public void SetY(float y)
    {
        this.y = y;
    }

    public float[] GetXY()
    {
        return new float[] { x, y };
    }

    public void SetXY(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return $"({x}, {y})";
    }
}

public class Point3D : Point2D
{
    private float z = 0.0f;

    public Point3D() { }

    public Point3D(float x, float y, float z) : base(x, y)
    {
        this.z = z;
    }

    public float GetZ()
    {
        return z;
    }

    public void SetZ(float z)
    {
        this.z = z;
    }

    public float[] GetXYZ()
    {
        return new float[] { GetX(), GetY(), z };
    }

    public void SetXYZ(float x, float y, float z)
    {
        SetX(x);
        SetY(y);
        this.z = z;
    }

    public override string ToString()
    {
        return $"({GetX()}, {GetY()}, {z})";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Test Point2D ===");
        Point2D p1 = new Point2D();
        Console.WriteLine(p1);

        Point2D p2 = new Point2D(3.5f, 5.0f);
        Console.WriteLine(p2);

        p2.SetXY(1.0f, 2.0f);
        Console.WriteLine($"After SetXY: {p2}");

        float[] coords = p2.GetXY();
        Console.WriteLine($"X = {coords[0]}, Y = {coords[1]}");

        Console.WriteLine("\n=== Test Point3D ===");
        Point3D p3d1 = new Point3D();
        Console.WriteLine(p3d1);

        Point3D p3d2 = new Point3D(1.0f, 2.0f, 3.0f);
        Console.WriteLine(p3d2);

        p3d2.SetXYZ(7.0f, 8.0f, 9.0f);
        Console.WriteLine($"After SetXYZ: {p3d2}");

        float[] coords3D = p3d2.GetXYZ();
        Console.WriteLine($"X = {coords3D[0]}, Y = {coords3D[1]}, Z = {coords3D[2]}");
    }
}
