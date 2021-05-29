using System;

namespace SumOfAllIntegersBetween
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 3;

            Console.WriteLine("The result is " + GetSum(a, b));
        }

        public static int GetSum(int a, int b)
        {
            // Returns the larger of two specified numbers
            int max = Math.Max(a, b);
            //Returns the smaller of two specified numbers
            int min = Math.Min(a, b);
            int result = 0;

            for (int i = min; i <= max; i++)
            {
                result += i;
            }
            return result;
        }
    }
}
