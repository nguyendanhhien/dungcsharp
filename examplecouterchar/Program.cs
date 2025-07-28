using System;
using System.Collections.Generic;

public class Program
{
    // Hàm xử lý đếm ký tự
    static Dictionary<char, int> CountCharacters(string input)
    {
        Dictionary<char, int> characterCount = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (characterCount.ContainsKey(c))
            {
                characterCount[c]++;
            }
            else
            {
                characterCount[c] = 1;
            }
        }
        return characterCount;
    }

    // Hàm Main chính
    public static void Main(string[] args)
    {
        Console.WriteLine("Input string:");
        string input = Console.ReadLine();

        Dictionary<char, int> result = CountCharacters(input);

        Console.WriteLine("Character counts:");
        foreach (var pair in result)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
