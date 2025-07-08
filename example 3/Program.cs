public class Program
{
    public static void Main(string[] args)
    {
        double bankinh;
        Console.WriteLine("Hay nhap ban kinh hinh tron");
        bankinh = Convert.ToDouble(Console.ReadLine());
        double chuvi = Math.PI * bankinh * 2;
        double dientich = Math.PI * bankinh * bankinh;
        Console.WriteLine($"Chu vi hinh tron la {chuvi} ");
        Console.WriteLine($"Dien tich hinh tron la {dientich}");
    }
}
