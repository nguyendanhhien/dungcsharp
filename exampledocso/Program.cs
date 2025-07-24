public class Program
{
    public static void Main(string[] args)
    {
        int so;
        Console.WriteLine("Nhap so can doc tu trong khoang tu 0 den 1000:");
        so = Convert.ToInt32(Console.ReadLine());
        if (so < 0 || so > 1000)
        {
            Console.WriteLine("So khong hop le, vui long nhap lai.");
        }
        else
        {
            string[] units = { "khong", "mot", "hai", "ba", "bon", "nam", "sau", "bay", "tam", "chin" };
            string[] tens = { "linh", "muoi", "hai muoi", "ba muoi", "bon muoi", "nam muoi", "sau muoi", "bay muoi", "tam muoi", "chin muoi" };
            string[] hundreds = { "", "mot tram", "hai tram", "ba tram", "bon tram", "nam tram", "sau tram", "bay tram", "tam tram" };

            if (so == 0)
            {
                Console.WriteLine("Khong");
            }
            else
            {
                int hundred = so / 100;
                int ten = (so % 100) / 10;
                int unit = so % 10;

                string result = "";

                if (hundred > 0)
                {
                    result += hundreds[hundred] + " ";
                }

                if (ten > 1)
                {
                    result += tens[ten] + " ";
                }
                else if (ten == 1)
                {
                    result += tens[1] + " ";
                }
                else if (ten == 0 && hundred > 0)
                {
                    result += "linh ";
                }

                if (unit > 0 || (hundred == 0 && ten == 0))
                {
                    result += units[unit];
                }

                Console.WriteLine(result.Trim());
            }

        }
    }
}