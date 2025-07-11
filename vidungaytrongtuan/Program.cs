public class Program
{
    public static void Main(string[] args)
    {
        string ngay = "abc";
        switch (ngay)
        {
            case "monday":
                Console.WriteLine("La ngay thu 2");
                break;
            case "tuesday":
                Console.WriteLine("La ngay thu 3");
                break;
            case "wenesday":
                Console.WriteLine("la ngay thu 4");
                break;
            case "thursday":
                Console.WriteLine("La ngay thu 5");
                break;
            case "friday":
                Console.WriteLine("La ngay thu 6");
                break;
            case "saturday":
                Console.WriteLine("La ngay thu 7");
                break;
            case "sunday":
                Console.WriteLine("La ngay chu nhat");
                break;
            default:
                Console.WriteLine("Nhap so ngay bang tieng anh nha");
                break ;
                
                
            

        }
        
    }
}