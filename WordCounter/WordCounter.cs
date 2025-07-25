using System;

class WordCounter
{
    static void Main()
    {
        Console.WriteLine("Nhập một chuỗi:");
        string input = Console.ReadLine();

        int wordCount = CountWords(input);
        Console.WriteLine($"Số từ trong chuỗi là: {wordCount}");
    }

    static int CountWords(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return 0;

        string[] words = text.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}
