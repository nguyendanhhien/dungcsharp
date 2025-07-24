public class Program
{
    public static void Main(string[] args)
    {
        int[] myarray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int sum = 0;
        for (var i = 0; i < myarray.Length; i++)
        {
            sum += myarray[i];
        }
        Console.WriteLine(sum);
    }
}