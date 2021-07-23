using System;

namespace OddIntFinder
{
    //Codewars exercise:
    //Given an array of integers, find the one that appears an odd number of times.
    //There will always be only one integer that appears an odd number of times.
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };
            Console.WriteLine("The program contains the following integer which appears an odd number of times "
                + find_it(numbers));
        }

        public static int find_it(int[] seq)
        {
            //Pseudo-Code Thinking:
            //- find every unique number in array
            //- count how many times the number appears
            //  - if even, continue with next number
            //  - if odd, return number and stopp loop
            //
            //think about what search algorithm is the best
            return -1;
        }
    }
}
