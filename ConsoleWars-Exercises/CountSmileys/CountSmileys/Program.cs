using System;

namespace CountSmileys
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] smileyArray = {":)", ";)", ";}", ":-D"};

            Console.WriteLine("The number of correct smileys is: " + CountSmileys(smileyArray));
        }

        public static int CountSmileys(string[] smileys)
        {
            int count = 0;

            foreach (string smiley in smileys)
            {
                switch (smiley)
                {
                    case ":-)":
                        count++;
                        break;
                    case ":-D":
                        count++;
                        break;
                    case ":~)":
                        count++;
                        break;
                    case ":~D":
                        count++;
                        break;
                    case ":)":
                        count++;
                        break;
                    case ":D":
                        count++;
                        break;
                    case ";-)":
                        count++;
                        break;
                    case ";-D":
                        count++;
                        break;
                    case ";~)":
                        count++;
                        break;
                    case ";~D":
                        count++;
                        break;
                    case ";)":
                        count++;
                        break;
                    case ";D":
                        count++;
                        break;
                }
            }
            return count;
        }
    }
}
