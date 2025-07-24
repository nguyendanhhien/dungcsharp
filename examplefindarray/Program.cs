using System;

public class Program
{
    public static void Main(string[] args)
    {
        string[] student = { "Christmas", "Michanel", "Cmalilia", "Sinena" };
        Console.WriteLine("Ban hay nhap mot cai ten:");
        string inputname = Console.ReadLine(); // <-- Thêm dòng này để lấy tên từ người dùng

        bool isExit = false;
        for (var i = 0; i < student.Length; i++)
        {
            if (student[i].Equals(inputname))
            {
                Console.WriteLine($"Co ten do trong mang o vi tri la {i}");
                isExit = true;
                break;
            }
        }

        if (!isExit)
        {
            Console.Write("Khong tim thay ten nhu vay");
        }
    }
}
