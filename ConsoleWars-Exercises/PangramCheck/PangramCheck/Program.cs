using System;

namespace PangramCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a sentence to check if it is a pengram or not");

            string userString = Console.ReadLine();
            userString.ToLower();

            Console.WriteLine(IsPangram(userString));
        }

        //TODO: Is IndexOf() really the best solution for this exercies? No better way?
        public static bool IsPangram(string str)
        {
            str = str.ToLower();
            string[] alphabetCharacters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            foreach (string alphabet in alphabetCharacters)
            {
                //if IndexOf() doesn't find the string it returns -1
                if (str.IndexOf(alphabet) == -1)
                    return false;
            }
            return true;
        }
    }
}
