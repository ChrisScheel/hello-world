using System;

namespace SumOf2LowestPosInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] posInt = { 19, 4, 42, 2, 77 };

            if (posInt.Length >= 4)
            {
                Console.WriteLine(sumTwoSmallestNumbers(posInt));
            }
            else
            {
                Console.WriteLine("Please use an array which consists of at least 4 numbers");
            }
        }

        public static int sumTwoSmallestNumbers(int[] numbers)
        {
                Array.Sort(numbers);
 
                int lowestNumber = numbers[0];
                int secondLowestNumber = numbers[1];
                int sumOfLowestNumbers = lowestNumber + secondLowestNumber;

                return sumOfLowestNumbers;
        }
    }
}
