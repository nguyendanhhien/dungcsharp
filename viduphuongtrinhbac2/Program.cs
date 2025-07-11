public class Program
{
    public static void Main(string[] args)
    {
        double a, b, c;
        Console.WriteLine("Nhap gia tri cua a:");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap gia tri cua b:");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap gia tri cua c:");
        c = Convert.ToDouble(Console.ReadLine());
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem.");
                }
            }
            else
            {
                double x = (-c) / b;
                Console.WriteLine($"Phuong trinh co nghiem duy nhat la: {x}");
            }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Phuong trinh co 2 nghiem la: {x1} va {x2}");
                }
                else if (delta == 0)
                {
                    double x0 = (-b) / (2 * a);
                    Console.WriteLine($"Phuong trinh co nghiem kep la: {x0}");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem.");
                }
            }
        }

    }

