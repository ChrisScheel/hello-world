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

            foreach(char a in charArray)
                if (Char.IsUpper(a))
                {
                    int index = -1;

                    foreach(char c in charArray)
                    {
                        index++;
                        if (char.IsUpper(c))
                        {
                            break;
                        }
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
