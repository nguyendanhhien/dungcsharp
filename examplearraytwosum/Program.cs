public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap so phan tu cua mang (ma trận vuông): ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[,] arr = new int[n, n];
        Console.WriteLine("Nhap cac phan tu cua mang:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Mang vua nhap la:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arr[i, i];                 // Đường chéo chính
            if (i != n - 1 - i)               // Tránh cộng hai lần phần tử trung tâm nếu n lẻ
            {
                sum += arr[i, n - 1 - i];     // Đường chéo phụ
            }
        }

        Console.WriteLine("Tong cac phan tu tren hai duong cheo la: " + sum);
    }
}
