using System;

class Program
{
    static void Main()
    {
        Console.Write("enter a text ");
        string text = Console.ReadLine().ToLower();

        int count = 0;

        foreach (char c in text)
        {
            if ("aeıioöuü".Contains(c))
                count++;
        }

        Console.WriteLine("Vowel count " + count);
    }
}
