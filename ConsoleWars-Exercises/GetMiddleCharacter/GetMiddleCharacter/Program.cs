using System;

namespace GetMiddleCharacter
{
    class Program
    {
        //Exercise:
        //You are going to be given a word. Your job is to return the middle character of the word.
        //If the word's length is odd, return the middle character. If the word's length is even, return the middle 2 characters.
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a word:");
            string userWord = Console.ReadLine();
            Console.WriteLine("The middle character(s): " + GetMiddle(userWord));
        }

        public static string GetMiddle(string s)
        {
            string middle = string.Empty;

            if (s.Length % 2 != 0)
            {
                char oddMiddleCharacter = s[(s.Length - 1) / 2];
                middle = oddMiddleCharacter.ToString();
            }
            else
            {
                char evenMiddleCharacter1 = s[(s.Length / 2) - 1];
                char evenMiddleCharacter2 = s[s.Length / 2];
                middle = evenMiddleCharacter1.ToString() + evenMiddleCharacter2.ToString();
            }
            return middle;
        }
    }
}
