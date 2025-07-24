//In so nguyen to trong mot khoang xac dinh
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap khoang a va b");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int Count = 0;
        for (var i = a; i < b; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine($"{i}");
                Count += 1;
            }
        }
        Console.WriteLine($"So nguyen to gom {Count} so.");
    }
    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (var i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}
