//khai bao lop (thuoc tinh, phuong thuc)
public abstract class Animal
{
    protected string Weight { get; set; }
    protected string Height { get; set; }
    public Animal(string weight, string height)
    {
        this.Weight = weight;
        this.Height = height;
    }
    public abstract void PrintInfo();
}
//khoi tao doi tuong 
class Cat : Animal
{
    private string Name { get; set; }
    public Cat(string name, string weight, string height) : base(weight, height)
    {
        this.Name = name;
    }
    public override void PrintInfo()
    {
        Console.WriteLine("Weight: {0}, Height: {1}, Name: {2}", this.Weight, this.Height, this.Name);
    }
    static void Main(string[] args)
    {
        Cat cat = new Cat("Tom", "4kg", "30cm");
        cat.PrintInfo();
    }
}

