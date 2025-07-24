public class Program
{
    public static void Main(string[] args)
    {
        int a;
        Console.WriteLine("Enter a number:");
        a = Convert.ToInt32(Console.ReadLine());
        int b;
        Console.WriteLine("Enter b number:");
        b = Convert.ToInt32(Console.ReadLine());
        a = Math.Abs(a);
        b = Math.Abs(b);
        if (a == 0 || b == 0)
        {
            Console.WriteLine("Khong the tim duoc UCLN");

        }
        else
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            Console.WriteLine("UCLN la: " + a);
        }

    }
}
