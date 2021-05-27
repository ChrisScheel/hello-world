using System;
using System.Text;

namespace FixStringCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string lowerUpperLetters = "COde";

            Console.WriteLine(Solve(lowerUpperLetters));
        }

        public static string Solve(string s)
        {
            int numberOfUpperChars = 0;
            int numberOfLowerChars = 0;
            /* REFACTOR: Solution is too big.
             * - The counting for the number of Upper/Lower Chars doesn't have to be seperate.
             * - Don't use so many else if and foreach. For example numberOfUpperChars == numberOfLowerChars
             *   doesn't have to be like this */
            foreach (char c in s)
            {
                if (Char.IsUpper(c))
                {
                    numberOfUpperChars++;
                }
                else if (Char.IsLower(c))
                {
                    numberOfLowerChars++;
                }
            }

            StringBuilder alteredString = new StringBuilder();

            if (numberOfUpperChars > numberOfLowerChars)
            {
                foreach (char c in s)
                {
                    if (Char.IsLower(c))
                    {
                        alteredString.Append(Char.ToUpper(c));
                    }
                    else
                    {
                        alteredString.Append(c);
                    }
                }
            }
            else if (numberOfUpperChars < numberOfLowerChars)
            {
                foreach (char c in s)
                {
                    if (Char.IsUpper(c))
                    {
                        alteredString.Append(Char.ToLower(c));
                    }
                    else
                    {
                        alteredString.Append(c);
                    }
                }
            }
            else if (numberOfUpperChars == numberOfLowerChars)
            {
                foreach(char c in s)
                {
                    alteredString.Append(Char.ToLower(c));
                }
            }
            return alteredString.ToString();
        }
    }
}
