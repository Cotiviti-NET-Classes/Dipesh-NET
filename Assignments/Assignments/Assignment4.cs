using System;
using System.Collections.Generic;

namespace Assignments;

class FileHandle
{
    public void data()
    {
        // Read the file as one string.
        string texts = File.ReadAllText("check.txt");

        // Read the file as an array.
        string[] textArray = File.ReadAllLines("check.txt");



        //for counting words.
        int wordCount = 0;
        // int sentenceCount = 0;
        foreach (string text in textArray)
        {
            wordCount += text.Split(' ').Length;
            // sentenceCount += texts.Split(" [!?.:]+").Length;
        }
        Console.WriteLine("Words:" + wordCount);
        // Console.WriteLine("Sentence:" + sentenceCount);



        //vowels count
        int vowelCount = System.Text.RegularExpressions.Regex.Matches(texts.ToLower(), "[aeoiu]").Count;
        int sentenceCount = System.Text.RegularExpressions.Regex.Matches(texts, "[.!?]").Count;
        Console.WriteLine($"Total vowels: {vowelCount}");
        Console.WriteLine($"Total sentence: {sentenceCount}");



        // check for characters and special character count
        string str = texts;

        char[] specialChar = new char[] {'~', '`', '!', '@', '#', '$', '%', '^', '&', '*','(', ')', '-', '_',
        '+', '=', '{', '}', '[', ']', '|', '?', '/', '.', ',', '<', '>', '\'', '\"', ':', ';'};

        // Creating array of string length 
        char[] ch = new char[str.Length];
        int charCount = 0;
        int specialCharCount = 0;
        int spaceCount = 0;
        int lineBreakCount = 0;
        // Copy character by character into array 
        for (int i = 0; i < str.Length; i++)
        {
            ch[i] = str[i];

        }

        // Printing content of array 
        foreach (char c in ch)
        {
            // Console.WriteLine(c);
            if (!specialChar.Contains(c) && c != '\n' && c != ' ')
            {
                charCount += 1;
                // Console.WriteLine("space");
            }
            else if (specialChar.Contains(c))
            {
                specialCharCount += 1;
            }
            else if (c == ' ')
            {
                spaceCount += 1;
                // specialCharCount += 1;
                // Console.WriteLine("space");
            }
            else
            {
                lineBreakCount += 1;
            }
        }
        Console.WriteLine("Char: " + charCount);
        Console.WriteLine("Special Char: " + specialCharCount);
        Console.WriteLine("Space: " + spaceCount);
        Console.WriteLine("line break: " + lineBreakCount);

        //sentences count
        // int sentenceCount = text.Split("[!?.:]+").Length;
        // Console.WriteLine($"Total sentence: {sentenceCount}");
    }
}