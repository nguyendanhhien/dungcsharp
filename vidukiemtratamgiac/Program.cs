public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap do dai canh a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap do dai canh b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap do dai canh c: ");
        double c = Convert.ToDouble(Console.ReadLine());
        if (a > 0 && b > 0 && c > 0)
        {
            if ((a + b) > c && (b + c) > a && (c + a) > b)
            {
                Console.WriteLine("Ba canh tren co the tao duoc hinh tam giac.");

            }
            else
            {
                Console.WriteLine("Ba canh tren khong the tao hinh tam giac");
            }
        }
        else
        {
            Console.WriteLine("Canh cua tam giac phai lon hon 0.");
        }
    }
}