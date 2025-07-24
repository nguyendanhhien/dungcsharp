public class Program
{
    public static void Main(string[] args)
    {
        int[] myarray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        Console.WriteLine(myarray[1]);
        for (var i = myarray.Length; i >0 ; i--)
        {
            Console.WriteLine(myarray[i]);
        }
        foreach (var item in myarray)
        {
            Console.Write(item);
        }
    }
}