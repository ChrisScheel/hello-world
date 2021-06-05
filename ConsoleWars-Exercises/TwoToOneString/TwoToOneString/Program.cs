using System;

namespace TwoToOneString
{
    class Program
    {
        private static string[] alphabetLetters = new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        static void Main(string[] args)
        {
            string a = "xyaabbbccccdefww";
            string b = "xxxxyyyyabklmopq";

            Console.WriteLine("The new string contains the following letters {0}. Multiple occurrences of a letter have been deleted.", Longest(a,b));
        }

        public static string Longest(string s1, string s2)
        {
            string combinedString = String.Concat(s1, s2);
            string returnString = String.Empty;

            for (int i = 0; i < alphabetLetters.Length; i++)
            {
                if (combinedString.Contains(alphabetLetters[i]))
                {
                    returnString += String.Concat(alphabetLetters[i]);
                }
            }
            return returnString;
        }
    }
}
