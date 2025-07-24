public class Program
{
    public static void Main(string[] args)
    {
        string[,] myarray = {{ "Ha Noi", "HCM", "Thai Nguyen" },
                { "Cao Bang", "Bac Can ","Hon Gai"},
                { "Lam Dong", "An Giang","vung Tau"}, };
        Console.WriteLine("Array Length:" + myarray.GetLength(0));
        Console.WriteLine("Array Length:" + myarray.GetLength(1));
    }
}
