using System;

namespace TortoiseRun
{
    class Program
    {
        static void Main(string[] args)
        {
            int aTortoiseSpeedFeetPerHour = 720;
            int bTortoiseSpeedFeetPerHour = 850;
            int leadInFeet = 70;

            foreach (int n in Race(aTortoiseSpeedFeetPerHour, bTortoiseSpeedFeetPerHour, leadInFeet))
            {
                Console.Write("{0} ", n);
            }
        }

        public static int[] Race(int v1, int v2, int g)
        {
            int[] speedInHoursMinutesSeconds = new int[3];

            //if v1 >= v2, Tortoise B has no chance to reach Tortoise A
            if (v1 >= v2)
            {
                speedInHoursMinutesSeconds[0] = -1;
                speedInHoursMinutesSeconds[1] = -1;
                speedInHoursMinutesSeconds[2] = -1;

                /*Codewars expected the following solution despite saying that -1, -1, -1 is ok too:
                 *      return speedInHoursMinutesSeconds = null;
                 */
            }
            else
            {
                double timeTillReachedinHours = (double)g / ((double)v2 - (double)v1);

                var timeSpan = TimeSpan.FromHours(timeTillReachedinHours);
                int hh = timeSpan.Hours;
                int mm = timeSpan.Minutes;
                int ss = timeSpan.Seconds;

                speedInHoursMinutesSeconds[0] = hh;
                speedInHoursMinutesSeconds[1] = mm;
                speedInHoursMinutesSeconds[2] = ss;
            }

            return speedInHoursMinutesSeconds;
        }
    }
}
