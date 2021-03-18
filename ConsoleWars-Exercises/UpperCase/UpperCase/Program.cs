using System;

namespace UpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert Jaden text: ");
            string jadenText = Console.ReadLine();

            Console.WriteLine(ToJadenCase(jadenText));
        }

        public static string ToJadenCase(string phrase)
        {
            return phrase.ToUpper();
        }
    }
}
