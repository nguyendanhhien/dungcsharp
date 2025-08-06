using System;

public class Program
{
    public static int CountCharacter(string str, char ch)
    {
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ch)
            {
                count++;
            }
        }
        return count;
    }

    public static void Main(string[] args)
    {
        string str = "hello world";
        Console.Write("Enter a character to count: ");
        char inputChar = char.Parse(Console.ReadLine());

        int result = CountCharacter(str, inputChar);
        Console.WriteLine($"Character '{inputChar}' appears {result} time(s).");
    }
}
