public class Program
{
    public static void Main(string[] args)
    {
        int tienviet;
        int tiendola;
        Console.WriteLine("Nhap so tien do la: ");
        tiendola = Convert.ToInt32(Console.ReadLine());
        tienviet = tiendola * 23000;
        Console.WriteLine("So tien Viet Nam la: " + tienviet); 
        

    }
}