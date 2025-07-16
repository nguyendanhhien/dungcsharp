public class Program
{
    public static void Main(string[] args)
    {
        string diem = "A";
        string xeploai = diem switch
        {
            "A" => "Xuat sac",
            "B" => "Gioi",
            "C" => "Kha",
            "D" => "Yeu",
            _ => "Khong hop le"
        };
        Console.WriteLine(xeploai);
    }
}
