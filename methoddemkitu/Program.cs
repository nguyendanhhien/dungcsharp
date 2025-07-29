using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hay nhap chuoi ban can dem so ki tu: ");
        string input = Console.ReadLine();

        Console.Write("Nhap ky tu can dem: ");
        char inputChar = char.Parse(Console.ReadLine());

        int count = CountCharacter(input, inputChar);
        Console.WriteLine($"Ky tu '{inputChar}' xuat hien {count} lan.");
    }

    public static int CountCharacter(string input, char inputChar)
    {
        int count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == inputChar)
            {
                count++;
            }
        }
        return count;
    }
}
