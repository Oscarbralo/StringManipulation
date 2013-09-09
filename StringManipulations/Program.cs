using System;
﻿using SYstem.Collection.Generic;
using System.Text;

namespace StringManipulations
{
    class Program
    {
        static string ReverseString(string to_reverse)
        {
            StringBuilder reversal = new StringBuilder(to_reverse.Length);

            for (int i = to_reverse.Length - 1; i >= 0; i--)
            {
                reversal.Append(to_reverse[i]);
            }

            return reversal.ToString();
        }

        static string AlphabetizeString(string to_alphabetize)
        {
            char[] buffer = to_alphabetize.ToCharArray();

            Array.Sort(buffer);

            return new string(buffer);

        }
        
        static string AlphabetizeStringWithoutRepeating(string to_alphabetize)
        {
            StringBuilder sb = new StringBuilder();
            List<char> list = new List<char>();
            char[] buffer = to_alphabetize.ToCharArray();
            Array.Sort(buffer);
            for(int i = 0; i < buffer.Length; i++)
            {
                if(!list.Contains(buffer[i]) && buffer[i] != ' ')
                {
                    list.Add(buffer[i]);
                    sb.Append(buffer[i]);
                }
            }
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            // Length
            int length = input.Length;

            // Reverse
            string reversed = ReverseString(input);

            // Alphabetize
            string alphabetized = AlphabetizeString(input).Trim();
            
            string alphabetizedWithoutRepeated = AlphabetizeStringWithoutRepeating(input);
            
            string[] lines = {
                                "Original:\t" + input,
                                "==========================",
                                "Length:\t\t" + length,
                                "Reversed:\t" + reversed,
                                "Alphabetized:\t" + alphabetized,
                                "Alphabetized without repeated chars:\t" + alphabetizedWithoutRepeated
                             };

            System.IO.File.WriteAllLines("output.txt", lines);
        }
    }
}
