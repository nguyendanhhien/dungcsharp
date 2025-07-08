public class Program
{
    public static void Main(string[] args)
    {
        float chieucao;
        float chieurong;
        Console.WriteLine("Hay nhap chieu cao");
        chieucao = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hay nhap chieu rong");
        chieurong = Convert.ToInt32(Console.ReadLine());
        float dientich = chieucao * chieurong;
        Console.WriteLine($"Gia tri dien tich la {dientich}" );
    }
}
