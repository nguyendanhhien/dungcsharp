public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter two integers:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int max = Max(a, b);
        PrintMax(a, b);
    }
    public static int Max(int a, int b)
    {
        return (a > b) ? a : b;
    }
    public static void PrintMax(int a, int b)
    {
    Console.WriteLine($"The maximum of {a} and {b} is: {Max(a, b)}");
    }
}
