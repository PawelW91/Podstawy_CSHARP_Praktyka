namespace JZLICZ___Zliczacz_liter
{
    using System;
    using System.Collections.Generic;
    internal class Program
    {
        static void CountLetters()
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                Dictionary<char, int> lowercaseOccurrences = new Dictionary<char, int>();
                Dictionary<char, int> uppercaseOccurrences = new Dictionary<char, int>();

                // Initialize dictionaries with letters and their occurrences
                for (char c = 'a'; c <= 'z'; c++)
                {
                    lowercaseOccurrences[c] = 0;
                }
                for (char c = 'A'; c <= 'Z'; c++)
                {
                    uppercaseOccurrences[c] = 0;
                }

                // Process text lines
                for (int i = 0; i < n; i++)
                {
                    string line = Console.ReadLine();
                    foreach (char ch in line)
                    {
                        if (char.IsLetter(ch))
                        {
                            if (char.IsLower(ch))
                            {
                                lowercaseOccurrences[char.ToLower(ch)]++;
                            }
                            else
                            {
                                uppercaseOccurrences[char.ToUpper(ch)]++;
                            }
                        }
                    }
                }

                // Print lowercase letter occurrences
                foreach (char c in lowercaseOccurrences.Keys)
                {
                    if (lowercaseOccurrences[c] > 0)
                    {
                        Console.WriteLine($"{c} {lowercaseOccurrences[c]}");
                    }
                }

                // Print uppercase letter occurrences
                foreach (char c in uppercaseOccurrences.Keys)
                {
                    if (uppercaseOccurrences[c] > 0)
                    {
                        Console.WriteLine($"{c} {uppercaseOccurrences[c]}");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            CountLetters();
        }
    }
}
