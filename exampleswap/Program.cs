public class Program
{
    public static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        Console.WriteLine($"Before Swap: a: {a}, b: {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"a: {a}, b: {b}");
    }
    public static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}
