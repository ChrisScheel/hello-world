using System;
using System.Text;

namespace BinaryToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] binaryNumbers = { 0, 1, 0, 1,};

            Console.WriteLine("The number is {0}", binaryArrayToNumber(binaryNumbers));
        }

        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            StringBuilder binary = new StringBuilder();

            foreach(int n in BinaryArray)
            {
                binary.Append(n);
            }

            string resultBinary = binary.ToString();
            // The base of binary is 2. Therefore the the value of "Base" must be 2
            return Convert.ToInt32(resultBinary, 2);

            /*Alternative solution from Codewars:
             *       public static int binaryArrayToNumber(int[] BinaryArray)
                    {
                        string num = string.Empty;
                        foreach (var item in BinaryArray)
                        {
                             num += item.ToString();
                        }
                    return Convert.ToInt32(num,2);
                    }
            */
        }
    }
}
