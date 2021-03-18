using System;

namespace MakeNumberNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert an int number");

            string userInput = Console.ReadLine();
            //no check if input is a text because not required by this exercise
            int userNumber = Convert.ToInt32(userInput);

            Console.WriteLine(MakeNegative(userNumber));
        }

        public static int MakeNegative(int number)
        {
            if (number >= 0)
            {
                return number * -1;
            }
            else
            {
                return number;
            }
        }
    }
}
