using System;
using System.Text;

namespace GreetMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please tell me your name ");
            
            string userName = Console.ReadLine();
            Console.WriteLine(Greet(userName));
        }

        public static string Greet(string name)
        {
            //REFACTOR: Bad way with a lot of new strings. Use String Builder
            string loweredName = name.ToLower();
            char firstLetterOfName = loweredName[0];
            char firstLetterOfNameUpper = char.ToUpper(firstLetterOfName);
            string newName = firstLetterOfNameUpper + loweredName.Remove(0, 1);
            
            string greetUser = "Hello " + newName + "!";
            return greetUser;
            
        }
    }
}
