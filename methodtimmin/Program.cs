public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 5, 3, 8, 1, 4 };
        int index = MinValue(arr);
        Console.WriteLine($"Minimum value is at index: {index}");
        Console.WriteLine($"Minimum value is: {arr[index]}");

    }
    public static int MinValue(int[] array)
    {
        int min = array[0];
        int index = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index = i;
            }
        }
        return index;
        
    }
}
