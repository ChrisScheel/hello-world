using System;
using System.Text;

namespace ShortestWordInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "turns out random test cases are easier than writing out basic ones";

            Console.WriteLine(FindShort(input));
        }

        public static int FindShort(string s)
        {
            //The String.Split() method splits a string into an array of strings separated by the split delimeters.
            string[] Words = s.Split(' ');

            int intShortLength = Words[0].Length;

            foreach (string word in Words)
            {
                if (word.Length < intShortLength)
                {
                    intShortLength = word.Length;
                }
            }

            return intShortLength;
        }
    }
}
