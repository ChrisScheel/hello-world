using System;

namespace OddEvenCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {0, 1, 4, 1};

            Console.WriteLine("Test if the sum of numbers is odd or even");
            Console.WriteLine(OddOrEven(myArray));
        }

        public static string OddOrEven(int[] array)
        {
            int sum = 0;

            foreach (int value in array)
            {
                sum += value;
            }

            if (sum%2 == 0 )
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }       
        }
    }
}
