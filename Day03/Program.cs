using System;
using System.IO;

class Program
{
    private static void Main(string[] args)
    {
        string[] input = File.ReadAllLines("../../../input.txt");
        int total = 0;

        // First part
        foreach (string line in input)
        {
            // Split the line into two parts
            string first = line[..(line.Length / 2)];
            string second = line[(line.Length / 2)..];

            foreach (char c in first)
            {
                if (second.Contains(c))
                {
                    total += GetPriority(c);
                    break;
                }
            }
        }

        Console.WriteLine(total);

        total = 0;

        // Second part
        for (int i = 0; i < input.Length; i += 3)
        {
            foreach (char c in input[i])
            {
                if (input[i + 1].Contains(c) && input[i + 2].Contains(c))
                {
                    total += GetPriority(c);
                    break;
                }
            }
        }

        Console.WriteLine(total);
        Console.ReadKey();

        // Method to return the priority of a character
        int GetPriority(char c)
        {
            return char.IsUpper(c) ? c - 'A' + 27 : c - 'a' + 1;
        }
    }
}