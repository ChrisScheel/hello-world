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
            int oddMiddleIndex = (s.Length - 1) / 2;
            int evenMiddleIndex1 = (s.Length / 2) - 1;
            int evenMiddleIndex2 = s.Length / 2;

            if (string.IsNullOrEmpty(s))
            {
                middle = "";
            }
            else if (s.Length % 2 != 0)
            {
                middle = s[oddMiddleIndex].ToString();
            }
            else
            {
                middle = s[evenMiddleIndex1].ToString() + s[evenMiddleIndex2].ToString();
            }
            return middle;
        }
    }
}
