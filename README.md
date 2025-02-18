# Word-Frequency-Analyzer
This C# program analyzes a text string and counts the frequency of each word. It processes your input by removing punctuation, converting words to lowercase, and then displays the frequency of each word.
![WordFrequencyAnalyzer-ezgif com-optimize](https://github.com/user-attachments/assets/d5a4f6b3-00d0-4450-bf1a-cbf77b08b676)

🔹 How it works:

1️⃣ Input: The program prompts you to enter a string of text.

2️⃣ Processing:

    It splits the text into words using spaces and punctuation as delimiters.

    It converts all words to lowercase for consistent counting.

3️⃣ Counting: A dictionary is used to count how many times each word appears.

4️⃣ Output: The program displays the frequency of each word on the console.

```
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
```
