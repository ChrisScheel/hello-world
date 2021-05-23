using System;

namespace URL_Shortener
{
    class Program
    {
        static void Main(string[] args)
        {
            string toBeShortenedURL = "www.codewars.com#about";
            //string toBeShortenedURL = "www.codewars.com?page=1";

            Console.WriteLine(RemoveUrlAnchor(toBeShortenedURL));
        }

        public static string RemoveUrlAnchor(string url)
        {
            string shortenedURL = String.Empty;
            string toRemove = "#";

            int i = url.IndexOf(toRemove);

            if (i >= 0)
            {
                shortenedURL = url.Remove(i);
                return shortenedURL;
            }
            return url;
        }
    }
}
