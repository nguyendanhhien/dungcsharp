using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.Write("Nhap phan tu can xoa: ");
        int X = int.Parse(Console.ReadLine());

        int index_delete = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == X)
            {
                index_delete = i;
                break;
            }
        }

        if (index_delete != -1)
        {
            // Tạo mảng mới có độ dài giảm 1
            int[] newArr = new int[arr.Length - 1];
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (i == index_delete) continue; // bỏ qua phần tử cần xoá
                newArr[j++] = arr[i];
            }

            Console.WriteLine("Mang sau khi xoa phan tu {0}:", X);
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i] + " ");
            }
        }
        else
        {
            Console.WriteLine("Khong tim thay phan tu can xoa.");
        }
    }
}
