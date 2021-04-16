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
            MyList.Add("c"); //TODO: if a string appears several times it will always print out the same position -> 3 in this case. do it again!
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
            List<string> OutPutList = new List<string>();

            foreach(string a in lines)
            {
                //"+1+" was added to indexof() to print out position 1 and not 0, what could confuse the user
                OutPutList.Add(Convert.ToString(lines.IndexOf(a) + 1) + ": " + a);
            }
            return OutPutList;
        }
    }
}
