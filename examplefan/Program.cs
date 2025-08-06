//Tạo lớp quạt điện
public class Fan
{
    //Hiển thị tốc độ quạt
    const int slow = 1;
    const int medium = 2;
    const int fast = 3;
    //Tốc độ quạt, mặc định là slow
    private int speed = slow;
    //Trạng thái quạt, mặc định là false (tắt)
    private bool on = false;
    //Bán kính quạt, mặc định là 5
    private double radius = 5;
    //Màu sắc quạt, mặc định là "blue"
    private string color = "blue";
    //Thêm các thuộc tính getter và setter
    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }
    public bool On
    {
        get { return on; }
        set { on = value; }
    }
    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }
    public string Color
    {
        get { return color; }
        set { color = value; }
    }
    //Khởi tạo không có tham số
    public Fan()
    {

    }
    //Phương thức ToString()
    public override string ToString()
    {
        if (on)
        {
            return $"Fan is on: Speed={speed}, Color={color}, Radius={radius}";
        }
        else
        {
            return $"Fan is off: Color={color}, Radius={radius}";
        }
    }
    //Hiển thị bằng cách gọi ToString()
    public void Display()
    {
        Console.WriteLine(ToString());
    }
    //Tạo 2 đối tượng Fan
    public static void Main(string[] args)
    {
        Fan fan1 = new Fan();
        fan1.Speed = Fan.fast;
        fan1.On = true;
        fan1.Radius = 10;
        fan1.Color = "yellow";
        
        Fan fan2 = new Fan();
        fan2.Speed = Fan.medium;
        fan2.On = false;
        fan2.Radius = 5;
        fan2.Color = "blue";

        //Hiển thị thông tin quạt
        fan1.Display();
        fan2.Display();
    }

}
