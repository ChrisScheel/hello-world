using System;

namespace RowWeights
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] peopleWeight = { 13, 27, 49 };
            int[] peopleWeight = { 13 };

            foreach (int n in RowWeights(peopleWeight))
            {
                Console.Write("{0} ", n);
            }
        }

        public static int[] RowWeights(int[] a)
        {
            int totalGroupA = 0;
            int totalGroupB = 0;

            /*My beginner's mistake:
             * "i <= a.Length" is 1 too much! With three variables for example 
             * the length is 3 but the index only goes till 2
             */
            for (int i = 0; i < a.Length; i += 2)
            {
                totalGroupA += a[i];
            }
            for (int i = 1; i < a.Length; i += 2)
            {
                totalGroupB += a[i];
            }

            int[] weightGroupAB = { totalGroupA, totalGroupB };

            return weightGroupAB;

            /*Codewars solution because two for-loops might not be the best solution:
             *  int[] result = new int[2];

                for (int i = 0; i < a.Length; i++)
                {
                    if (i % 2 == 0)
                        result[0] += a[i];
                    else
                        result[1] += a[i];
                }
               return result;
            */
        }
    }
}
