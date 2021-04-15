using System;
using System.Collections.Generic;

namespace FilterStringsOutOfList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> MyList = new List<object>();
            MyList.Add("dd");
            MyList.Add(2);
            MyList.Add("a");
            MyList.Add("b");
            MyList.Add(12);
            MyList.Add(4522);

            foreach (int a in GetIntegersFromList(MyList))
            {
                Console.WriteLine(a);
            }
        }
        //returns only Integer values. No doubles and so on
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<Int32> IntList = new List<Int32>();

            foreach (var item in listOfItems)
            {
                Type t = item.GetType();

                if (t.Equals(typeof(Int32)))
                {
                    IntList.Add(Convert.ToInt32(item));
                }
            }
            return IntList;
        }
    }
}
