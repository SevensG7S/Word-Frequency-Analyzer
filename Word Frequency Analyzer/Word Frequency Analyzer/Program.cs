using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Console.WriteLine("Enter a string of text:");
        string input = Console.ReadLine();
        string[] words = ProcessText(input);

        Dictionary<string, int> frequency = GetWordFrequency(words);

        DisplayFrequency(frequency);
        Console.ReadKey();
    }


    static string[] ProcessText(string input)
    {
        string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i].ToLower();
        }
        return words;
    }

    static Dictionary<string, int> GetWordFrequency(string[] words)
    {
        Dictionary<string, int> frequency = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (frequency.ContainsKey(word))
            {
                frequency[word]++;
            }
            else
            {
                frequency.Add(word, 1);
            }
        }
        return frequency;
    }

    static void DisplayFrequency(Dictionary<string, int> frequency)
    {
        Console.WriteLine("\nFrequency:");
        foreach (KeyValuePair<string, int> pair in frequency)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
