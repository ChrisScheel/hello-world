using System;
using System.Text;

namespace CamelCaseBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string camelCase = "camelCase";
            //string camelCase = "camelcase";
            
            Console.WriteLine(BreakCamelCase(camelCase));
        }

        public static string BreakCamelCase(string str)
        {
            char[] charArray = str.ToCharArray();
            /*Refactor it:
             * It only works for Strings with one single upper case character
             * Code looks a bit nasty
             */
            foreach(char c in charArray)

                if (Char.IsUpper(c))
                {
                    int index = 0;

                    foreach(char a in charArray)
                    {
                        if (char.IsUpper(a))
                        {
                            break;
                        }
                        index++;
                    }

                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append(str);
                    stringBuilder.Insert(index, " ");
                    string stringWithSpace = stringBuilder.ToString();

                    return stringWithSpace;
                }
            return str;
        }
    }
}
