using System.Linq;
public class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
    var evenNumbers = numbers.Where(n => n % 2 == 0);

        foreach (var number in evenNumbers)
        {
            System.Console.WriteLine(number);
        }
    }
}