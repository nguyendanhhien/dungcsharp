using System;
using System.Collections.Generic;

namespace IndexOutOfRangeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Bước 1: Khởi tạo danh sách characters
                List<char> characters = new List<char>();
                characters.InsertRange(0, new char[] { 'a', 'b', 'c', 'd', 'e', 'f' });

                Console.WriteLine("Danh sách ký tự:");
                foreach (char c in characters)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();

                // Bước 2: Gán giá trị của phần tử thứ 6 (index = 6)
                // (chỉ có 6 phần tử => index hợp lệ 0..5, nên sẽ phát sinh lỗi)
                char value = characters[6];

                Console.WriteLine("Giá trị tại index 6: " + value);
            }
            catch (IndexOutOfRangeException ex)
            {
                // Bước 3: Bắt ngoại lệ và in ra thông báo
                Console.WriteLine("Đã xảy ra lỗi IndexOutOfRangeException!");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Chương trình tiếp tục chạy sau khi bắt lỗi.");
            Console.ReadLine();
        }
    }
}
