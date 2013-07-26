using System;
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
        
        //Added this method equal to Alphabetize but the return is without repeated characters
        static string AlphabetizeStringWithoutRepeatedChars(string to_alphabetize)
        {
            char[] buffer = to_alphabetize.ToCharArray();
            StringBuilder sr = new StringBuilder("");
            Array.Sort(buffer);
            for (int i = 0; i < buffer.Length; i++)
            {
                if (!sr.ToString().Contains(buffer[i].ToString()))
                    sr.Append(buffer[i].ToString());
            }
            return sr.ToString();
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
            
            string[] lines = {
                                "Original:\t" + input,
                                "==========================",
                                "Length:\t\t" + length,
                                "Reversed:\t" + reversed,
                                "Alphabetized:\t" + alphabetized
                             };

            System.IO.File.WriteAllLines("output.txt", lines);
        }
    }
}
