public class Program
{
    public static void Main(string[] args)
    {
        double tien = 1;
        double thang = 1;
        double interset_rate = 1.0;
        Console.WriteLine("Nhap gia tri dong tien");
        tien = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap gia tri thang");
        thang = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap gia tri ty gia ");
        interset_rate = Convert.ToDouble(Console.ReadLine());
        double total_interset = 0;
        for (var i = 0; i < thang; i++)
        {
            total_interset = tien * (interset_rate / 100) / 12 * 3;
        }
        Console.WriteLine(total_interset);
    }
}
