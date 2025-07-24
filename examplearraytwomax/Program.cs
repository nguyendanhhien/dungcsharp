using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[,] matrix = new int[3, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int max = matrix[0, 0]; // Khởi tạo max với phần tử đầu tiên

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("So lon nhat trong ma tran la: " + max);
    }
}
