public class Rectangle
{
    double width;
    double height;
    public Rectangle()
    {
        width = 0;
        height = 0;
    }



    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    public double GetArea()
    {
        return this.width * this.height;
    }
    public double GetPerimeter()
    {
        return 2 * (this.width + this.height);
    }
    public string Display()
    {
        return $"Width: {this.width}, Height: {this.height}, Area: {GetArea()}, Perimeter: {GetPerimeter()}";
    }


}
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the width of the rectangle:");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the height of the rectangle:");
        double height = Convert.ToDouble(Console.ReadLine());
        Rectangle rectangle = new Rectangle(width, height);
        Console.WriteLine(rectangle.Display());
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

}