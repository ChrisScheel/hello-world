using System;

namespace PositionOfMiddleElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] threeNumbers = { 2, 3, 1 };
            double[] threeNumbers = { 10, 14, 5 };

            Console.WriteLine("The index of the middle number is {0}", Gimme(threeNumbers));
        }

        //Works only for arrays with excactly three values
        //Doesn't check if there are duplicate numbers
        public static int Gimme(double[] inputArray)
        {
            double[] unSortedInputArray = new double[3];
            Array.Copy(inputArray, unSortedInputArray, 3);
            Array.Sort(inputArray);

            double middleNumber = inputArray[1];
            int indexOfMiddleValue = Array.IndexOf(unSortedInputArray, middleNumber);
            return indexOfMiddleValue;
        }
    }
}
