using System;

namespace ArithmeticFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = 2;
            double secondNumber = 4;

            Console.WriteLine("Please insert \"add\", \"substract\", \"multiply\" or \"divide\"");
            string op = Console.ReadLine();

            Console.WriteLine(Arithmetic(firstNumber, secondNumber, op));
        }

        public static double Arithmetic(double a, double b, string op)
        {
            switch (op)
            {
                case "add":
                    return a + b;
                case "substract":
                    return a - b;
                case "multiply":
                    return a * b;
                case "divide":
                    return a / b;
                default:
                    throw new Exception("Invalid operation. Maybe a typo?");
            }
        }
    }
}
