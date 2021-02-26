using System;

namespace PinCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Pin: ");
            string pin = Console.ReadLine();
            Console.WriteLine(ValidatePin(pin));
        }
        public static bool ValidatePin(string pin)
        {
            //TODO: Refactor it. It works but not in a very smart way
            char[] pinCharArray = pin.ToCharArray();
            bool isDigit = false;

            //checks if there are any non-digit values
            foreach (char a in pinCharArray)
            {
                if (Char.IsDigit(a) == false)
                {
                    isDigit = false;
                    break;
                }
                else
                {
                    isDigit = true;
                }
            }

            if (isDigit)
            {
                if (pin.Length == 4 || pin.Length == 6)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
