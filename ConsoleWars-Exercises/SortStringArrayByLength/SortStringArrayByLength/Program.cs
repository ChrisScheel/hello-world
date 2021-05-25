using System;
using System.Linq;

namespace SortStringArrayByLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] unsortedArray = {"Telescopes", "Glasses", "Eyes", "Monocles", "Hagass"};
            string[] sortedArray = SortByLength(unsortedArray);

            foreach (string s in sortedArray)
            {
                Console.WriteLine(s + " ");
            }
        }

        /* Solution with Linq (thx Stackoverflow)
         * TODO: Learn LINQ which is much easier for this type of exercise
         */
        public static string[] SortByLength(string[] array)
        {
            array = array.OrderBy(a => a.Length).ToArray();
            return array;
        }
    }
}
