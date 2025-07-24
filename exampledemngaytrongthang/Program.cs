public class Program 
{
    public static void Main(string[] args)
    {
        int thang;
        Console.WriteLine("Nhap thang ban muon dem so ngay:");
        thang = Convert.ToInt32(Console.ReadLine());
        int soNgay;
        switch (thang)
        {
            case 1: // January
            case 3: // March
            case 5: // May
            case 7: // July
            case 8: // August
            case 10: // October
            case 12: // December
                soNgay = 31;
                break;
            case 4: // April
            case 6: // June
            case 9: // September
            case 11: // November
                soNgay = 30;
                break;
            case 2: // February
                Console.WriteLine("Nhap nam:");
                int nam = Convert.ToInt32(Console.ReadLine());
                if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                {
                    soNgay = 29; // Leap year
                }
                else
                {
                    soNgay = 28; // Non-leap year
                }
                break;
            default:
                Console.WriteLine("Thang khong hop le.");
                return;
        }
        Console.WriteLine($"Thang {thang} co {soNgay} ngay.");
    }
}
