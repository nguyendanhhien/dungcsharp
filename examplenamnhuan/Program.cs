public class Program
{
    public static void Main(string[] args)
    {
        int nam;
        bool namnhuan = false;
        Console.Write("Nhap nam: ");
        nam = Convert.ToInt32(Console.ReadLine());
        if (nam % 4 == 0)
        {
            if (nam % 100 == 0)
            {
                if (nam % 400 == 0)
                {
                    namnhuan = true;
                }
            }
            else
            {
                namnhuan = true;
            }
        }
        if (namnhuan)
        {
            Console.WriteLine("Nam {0} la nam nhuan", nam);
        }
        else
        {
            Console.WriteLine("Nam {0} khong phai la nam nhuan", nam);
        }
        
    }
}