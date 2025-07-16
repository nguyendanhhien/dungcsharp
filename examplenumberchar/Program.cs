public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hay nhap mot so:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0 && number < 10)
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine("Khong");
                    break;
                case 1:
                    Console.WriteLine("Mot");
                    break;
                case 2:
                    Console.WriteLine("Hai");
                    break;
                case 3:
                    Console.WriteLine("Ba");
                    break;
                case 4:
                    Console.WriteLine("Bon");
                    break;
                case 5:
                    Console.WriteLine("Nam");
                    break;
                case 6:
                    Console.WriteLine("Sau");
                    break;
                case 7:
                    Console.WriteLine("Bay");
                    break;
                case 8:
                    Console.WriteLine("Tam");
                    break;
                case 9:
                    Console.WriteLine("Chin");
                    break;
                default:
                    break;
            }
        }
        else if (number >= 10 && number < 20)
        {
            switch (number)
            {
                case 10:
                    Console.WriteLine("Muoi");
                    break;
                case 11:
                    Console.WriteLine("Muoi mot");
                    break;
                case 12:
                    Console.WriteLine("Muoi hai");
                    break;
                case 13:
                    Console.WriteLine("Muoi ba");
                    break;
                case 14:
                    Console.WriteLine("Muoi bon");
                    break;
                case 15:
                    Console.WriteLine("Muoi nam");
                    break;
                case 16:
                    Console.WriteLine("Muoi sau");
                    break;
                case 17:
                    Console.WriteLine("Muoi bay");
                    break;
                case 18:
                    Console.WriteLine("Muoi tam");
                    break;
                case 19:
                    Console.WriteLine("Muoi chin");
                    break;
                default:
                    break;
            }
        }
        else if (number >= 20 && number <= 99)
        {
            int chuc = number / 10;
            int donvi = number % 10;
            switch (chuc)
            {

                case 2:
                    Console.WriteLine("Hai");
                    break;
                case 3:
                    Console.WriteLine("Ba");
                    break;
                case 4:
                    Console.WriteLine("Bon");
                    break;
                case 5:
                    Console.WriteLine("Nam");
                    break;
                case 6:
                    Console.WriteLine("Sau");
                    break;
                case 7:
                    Console.WriteLine("Bay");
                    break;
                case 8:
                    Console.WriteLine("Tam");
                    break;
                case 9:
                    Console.WriteLine("Chin");
                    break;
                default:
                    break;
            }
            switch (donvi)
            {
                case 0:
                    Console.WriteLine("Khong");
                    break;
                case 1:
                    Console.WriteLine("Mot");
                    break;
                case 2:
                    Console.WriteLine("Hai");
                    break;
                case 3:
                    Console.WriteLine("Ba");
                    break;
                case 4:
                    Console.WriteLine("Bon");
                    break;
                case 5:
                    Console.WriteLine("Nam");
                    break;
                case 6:
                    Console.WriteLine("Sau");
                    break;
                case 7:
                    Console.WriteLine("Bay");
                    break;
                case 8:
                    Console.WriteLine("Tam");
                    break;
                case 9:
                    Console.WriteLine("Chin");
                    break;
                default:
                    break;
            }
        }
    }
}
