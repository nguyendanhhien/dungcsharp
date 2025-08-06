//tạo lớp stopwatch
public class Stopwatch
{
    //Private StartTime và EndTime có trả về giá trị
    private DateTime StartTime { get; set; }
    private DateTime EndTime { get; set; }


    //Khởi tạo không tham số với thời gian của hệ thống
    public Stopwatch()
    {
        StartTime = DateTime.Now;
        EndTime = DateTime.Now;
    }
    //Phương thức Start() để reset về thời gian hệ thống
    public void Start()
    {
        StartTime = DateTime.Now;
        EndTime = DateTime.Now;
    }
    //Phương thức Stop() để lấy thời gian hiện tại
    public void Stop()
    {
        EndTime = DateTime.Now;
    }
    //Phương thức Elapsed() để tính thời gian đã trôi qua tính theo milisecond
    public double Elapsed()
    {
        return (EndTime - StartTime).TotalMilliseconds;
    }
    //Chương trình đo thời gian thực thi thuật toán selection sort
    public static void Main(string[] args)
    {
        //Tạo mảng ngẫu nhiên
        int[] arr = new int[10000];
        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(1, 10001);
        }

        //Khởi tạo stopwatch
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        //Thực hiện thuật toán selection sort
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            //Hoán đổi phần tử
            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }

        stopwatch.Stop();
        Console.WriteLine($"Thời gian thực thi thuật toán selection sort: {stopwatch.Elapsed()} ms");
    }
}