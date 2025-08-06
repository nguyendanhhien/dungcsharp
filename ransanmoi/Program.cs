//tạo trò chơi răn săn mồi trên terminal
using System;
public class Program
{
    public static void Main(string[] args)
    {
        // Khởi tạo trò chơi rắn săn mồi
        Game game = new Game();

        // Bắt đầu trò chơi
        game.Start();
    }
}
public class Game
{
    public void Start()
    {
        // Logic để bắt đầu trò chơi rắn săn mồi
        Console.WriteLine("Trò chơi rắn săn mồi bắt đầu!");
        //tạo con rắn là một chuỗi các ô vuông
        string snake = "O"; // O đại diện cho đầu rắn
                            //tạo thức ăn là một ô vuông khác
        string food = "X"; // X đại diện cho thức ăn
                           //tạo tường là các ô vuông ở rìa màn hình
        string wall = "#"; // # đại diện cho tường
        // Hiển thị trạng thái ban đầu của trò chơi
        Console.WriteLine("Rắn: " + snake);
        Console.WriteLine("Thức ăn: " + food);
        Console.WriteLine("Tường: " + wall);
        //mảng 2 chiều cho màn hình game
        char[,] screen = new char[10, 10];
        //mảng một chiều cho vị trí các ô vuông của rắn
        int[] snakePosition = { 5, 5 }; // Vị trí ban đầu của rắn
        //một biến cho vị trí của thức ăn
        int foodPosition = 3; // Vị trí ban đầu của thức ăn
        //vòng lặp để cập nhật trạng thái trò chơi
        for (int i = 0; i < 10; i++)
        {
            // Cập nhật vị trí rắn
            screen[snakePosition[0], snakePosition[1]] = 'O';
            // Cập nhật vị trí thức ăn
            screen[foodPosition, foodPosition] = 'X';
            // Cập nhật tường
            for (int j = 0; j < 10; j++)
            {
                screen[0, j] = '#'; // Tường trên
                screen[9, j] = '#'; // Tường dưới
                screen[j, 0] = '#'; // Tường trái
                screen[j, 9] = '#'; // Tường phải
            }
            // Tạo tường bao quanh, rắn và thức ăn
            Console.Clear(); // Xóa
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    if (screen[row, col] == 'O')
                    {
                        Console.Write("O "); // Hiển thị đầu rắn
                    }
                    else if (screen[row, col] == 'X')
                    {
                        Console.Write("X "); // Hiển thị thức ăn
                    }
                    else if (screen[row, col] == '#')
                    {
                        Console.Write("# "); // Hiển thị tường
                    }
                    else
                    {
                        Console.Write(". "); // Ô trống
                    }
                }
                Console.WriteLine();
            }
            // Hiển thị vị trí rắn và thức ăn
            Console.WriteLine("Vị trí rắn: (" + snakePosition[0] + ", " + snakePosition[1] + ")");
            Console.WriteLine("Vị trí thức ăn: " + foodPosition);
            Console.WriteLine("Nhấn phím mũi tên để di chuyển rắn.");
            
        
            // Giả lập di chuyển rắn
            snakePosition[0] = (snakePosition[0] + 1) % 10; // Di chuyển xuống dưới
            snakePosition[1] = (snakePosition[1] + 1) % 10; // Di chuyển sang phải
                                                            // Giả lập ăn mồi
            if (snakePosition[0] == foodPosition && snakePosition[1] == foodPosition)
            {
                Console.WriteLine("Rắn đã ăn mồi!");
                // Tạo mồi mới
                foodPosition = (foodPosition + 1) % 10; // Di chuyển mồi
            }
            // tạo mồi mới đặt ở vị trí ngẫu nhiên
            Random random = new Random();
            foodPosition = random.Next(1, 9); // Tạo mồi mới ở vị trí ngẫu nhiên từ 1 đến 8

            // Hiển thị trạng thái hiện tại của trò chơi
            System.Threading.Thread.Sleep(500); // Tạm dừng để dễ quan sát
            //xử lý nhập từ bàn phím để di chuyển rắn
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    snakePosition[0] = (snakePosition[0] - 1 + 10) % 10; // Di chuyển lên
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    snakePosition[0] = (snakePosition[0] + 1) % 10; // Di chuyển xuống
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    snakePosition[1] = (snakePosition[1] - 1 + 10) % 10; // Di chuyển sang trái
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    snakePosition[1] = (snakePosition[1] + 1) % 10; // Di chuyển sang phải
                }
            }
        }
            
    }
}