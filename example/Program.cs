public class Program
{
    public static void Main(string[] args)
    {
        DateTime dateTime = DateTime.Now;
        Console.WriteLine($"{dateTime.Hour}{dateTime.Minute}{dateTime.Second}.");
    }
}