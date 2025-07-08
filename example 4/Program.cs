public class Program
{
    public static void Main(string[] args)
    {
        int sotuoi;
        Console.WriteLine("Hay nhap so tuoi cua ban");
        sotuoi = Convert.ToInt32(Console.ReadLine());
        bool dutuoi = sotuoi >= 18;
        Console.WriteLine($"Ban da du tuoi lay chong nha {dutuoi}");
        
    }
}