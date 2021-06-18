using System;

namespace CompareEndingOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = ":-)";
            string word2 = "!@#$%^&*() :-)";

            Console.WriteLine($"Does \"{word1}\" end with \"{word2}\"? " + Solution(word1, word2));
        }

        public static bool Solution(string str, string ending)
        {
            if (str.EndsWith(ending))
            {
                return true;
            }
            return false;
        }
    }
}
