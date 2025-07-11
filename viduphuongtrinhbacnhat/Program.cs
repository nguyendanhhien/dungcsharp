public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap gia tri cua a:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap gia tri cua b:");
        double b = Convert.ToDouble(Console.ReadLine());
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Phuong trinh co vo so nghiem.");

            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem.");
            }
        }
        else
        {
            double x = (-b) / a;
             Console.WriteLine($"Nghiem cua phuong trinh la {x}");
        }
       
    }
}