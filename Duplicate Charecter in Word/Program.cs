using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine().ToLower();

        List<char> duplicates = new List<char>();

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = i + 1; j < word.Length; j++)
            {
                if (word[i] == word[j] && !duplicates.Contains(word[i]))
                {
                    duplicates.Add(word[i]);
                }
            }
        }

        if (duplicates.Count > 0)
        {
            Console.WriteLine("The word has duplicate letters:");
            foreach (char duplicate in duplicates)
            {
                Console.WriteLine(duplicate);
            }
        }
        else
        {
            Console.WriteLine("The word does not have any duplicate letters.");
        }
        Console.ReadLine();
    }
}
