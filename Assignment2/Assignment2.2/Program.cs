using Assignment2._2.Entity;
using System;
using System.Collections.Generic;

namespace Assignment2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charCounted = new Dictionary<char, int>();
            char[] text = new char[50];
            Random rnd = new Random();
            TextAnalyzer textAnalyzer = new TextAnalyzer();
            text = textAnalyzer.GeneratedText(text, rnd);
            Console.WriteLine("The initial string: \n");
            PrintText(text);
            Array.Sort(text);
            Console.WriteLine("String sorted by asc order: \n");
            PrintText(text);
            Console.WriteLine("Count chars: \n");
            charCounted = CountChar(text);
            foreach (var key in charCounted.Keys)
            {
                Console.WriteLine(key + ": " + charCounted[key]);
            }

        }

        static void PrintText(char[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static Dictionary<char, int> CountChar(char[] text)
        {
            Dictionary<char, int> charCounted = new Dictionary<char, int>();
            charCounted.Add(text[0], 1);
            for (int i = 1; i < text.Length; i++)
            {
                if (charCounted.ContainsKey(text[i]))
                    charCounted[text[i]] += 1;
                else
                    charCounted.Add(text[i], 1);
            }
            return charCounted;
        }
    }
}
