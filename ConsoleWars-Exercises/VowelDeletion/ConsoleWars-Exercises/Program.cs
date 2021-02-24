using System;

namespace ConsoleWars_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some text: ");
            string userInputText = Console.ReadLine();
            Console.WriteLine("Text without vowels (except y): " + Disemvowel(userInputText));
        }

        public static string Disemvowel(string userInputText)
        {
            string noVowelsUserInputText = userInputText;
            string[] charsToRemove = { "A", "a", "E", "e", "I", "i", "O", "o", "U", "u" };

            foreach (string a in charsToRemove)
            {
                noVowelsUserInputText = noVowelsUserInputText.Replace(a, string.Empty);
            }
            return noVowelsUserInputText;
        }
    }
}