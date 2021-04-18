using System;

namespace CountSmileys
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] smileyArray = {":)", ";)", ";}", ":-D"};

            Console.WriteLine("The number of correct smileys is: " + CountSmileys(smileyArray));
        }

        public static int CountSmileys(string[] smileys)
        {
            int count = 0;

            foreach (string smiley in smileys)
            {
                /* Or more compact solution from codewars:
                 *         if(((smiley.Contains(':') || smiley.Contains(';'))) && ((smiley.Contains(')') || smiley.Contains('D'))) && !smiley.Contains(' '))
                count++;

                Or use regular expression what i didn't learn.
                */
                switch (smiley)
                {
                    case ":-)":
                        count++;
                        break;
                    case ":-D":
                        count++;
                        break;
                    case ":~)":
                        count++;
                        break;
                    case ":~D":
                        count++;
                        break;
                    case ":)":
                        count++;
                        break;
                    case ":D":
                        count++;
                        break;
                    case ";-)":
                        count++;
                        break;
                    case ";-D":
                        count++;
                        break;
                    case ";~)":
                        count++;
                        break;
                    case ";~D":
                        count++;
                        break;
                    case ";)":
                        count++;
                        break;
                    case ";D":
                        count++;
                        break;
                }
            }
            return count;
        }
    }
}
