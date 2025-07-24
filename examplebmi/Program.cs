public class Program
{
    public static void Main(string[] args)
    {
        int chieucao,
            cannang;
        Console.WriteLine("Nhap chieu cao cua ban (cm): ");
    chieucao = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap can nang cua ban (kg): ");
        cannang = Convert.ToInt32(Console.ReadLine());

        double bmi = (double)cannang / ((chieucao / 100.0) * (chieucao / 100.0));
        Console.WriteLine("Chi so BMI cua ban la: " + bmi);

        if (bmi < 18.5)
        {
            Console.WriteLine("Ban thieu can.");
        }
        else if (bmi < 24.9)
        {
            Console.WriteLine("Ban co can nang binh thuong.");
        }
        else if (bmi < 29.9)
        {
            Console.WriteLine("Ban thua can.");
        }
        else
        {
            Console.WriteLine("Ban bi beo phi.");
        }
    }
}