using System;

namespace WhoLikesThis
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] peopleName = { "John" };
            //string[] peopleName = { "John", "Alex"};
            //string[] peopleName = { "John", "Alex", "Heino"};
            string[] peopleName = { "John", "Alex", "Jack", "Jones", "Heino"};

            Console.WriteLine(Likes(peopleName));
        }

        /*TODO: Build a better method
         * - with switch/case
         * - with string interpolation
         * - with console user input in main method
         */
        public static string Likes(string[] name)
        {
            if (name.Length == 0)
            {
                return "no one likes this";
            }
            else if (name.Length == 1)
            {
                return name[0] + " likes this";
            }
            else if (name.Length == 2)
            {
                return name[0] + " and " + name[1] + " like this";
            }
            else if (name.Length == 3)
            {
                return name[0] + ", " + name[1] + " and " + name[2] + " like this";
            }
            else if (name.Length >= 4)
            {
                int others = name.Length - 2;
                return name[0] + ", " + name[1] + " and " + others + " others like this";
            }
            else
            {
                return "Something is wrong";
            }
        }
    }
}
