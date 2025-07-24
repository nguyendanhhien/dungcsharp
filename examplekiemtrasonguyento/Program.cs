public class Program
{
    public static void Main(string[] args)
    {
        int so = 0;
        Console.WriteLine("Nhap mot so nguyen:");
        so = Convert.ToInt32(Console.ReadLine());
        if (so < 2)
        {
            Console.WriteLine("Khong phai la so nguyen to");
        }
        else
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(so); i++)
            {
                if (so % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("La so nguyen to");
            }
            else
            {
                Console.WriteLine("Khong phai la so nguyen to");
            }
        }
    }
}
