public class Program
{
    public static void Main(string[] args)
    {
        int dem = 0;
        Console.WriteLine("Danh sach cac so nguyen to tu 1 den 100 la:");
        for (int i = 2; i <= 100; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine(i);
                dem++;
            }
        }
        Console.WriteLine("Tong so nguyen to tu 1 den 100 la: " + dem);
    }
}