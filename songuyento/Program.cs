public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hien thi cac so nguyen to ");
        for (var i = 2; i < 100; i++) 
        {
            if (IsPrime(i))
            {
                Console.WriteLine("" + i);
            }
        }
    }
    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (var i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;

    }
}