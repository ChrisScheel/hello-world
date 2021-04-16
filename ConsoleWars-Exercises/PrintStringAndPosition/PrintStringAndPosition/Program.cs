using System;
using System.Collections.Generic;

namespace PrintStringAndPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> MyList = new List<string>();
            MyList.Add("a");
            MyList.Add("b");
            MyList.Add("c");
            MyList.Add("c");
            MyList.Add("c");

            Console.WriteLine("The list contains the following words and their position: ");
            foreach (string a in Number(MyList))
            {
                Console.WriteLine(a);
            }
        }

        public static List<string> Number(List<string> lines)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = (i + 1) + ": " + lines[i];
            }
            return lines;

            /* Old code doesn't work properly. For example: If the list contains two or more of the same string, it won't print out the right position
             * of the element. With the example values above: "c" will always come with the position 3, not followed by 4 and 5 as expected.
             * 
             * foreach(string a in lines)
            {
                OutPutList.Add(Convert.ToString(lines.IndexOf(a) + 1) + ": " + a);
            }
            return OutPutList;
            */
        }
    }
}
