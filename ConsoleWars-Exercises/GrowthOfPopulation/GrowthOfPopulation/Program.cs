using System;

namespace GrowthOfPopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingPopulation = 1500;
            double growthInPercentYearly = 5;
            int additionalPeopleYearly = 100;
            int goalPopulation = 5000;

            Console.WriteLine("It takes {0} years until you reach your goal population", NbYear(startingPopulation, growthInPercentYearly, additionalPeopleYearly, goalPopulation));
        }

        public static int NbYear(int startingPopulation, double growthInPercentYearly, int additionalPeopleYearly, int goalPopulation)
        {
            int amountOfPeopleInYear = startingPopulation;
            double increaseByYear = growthInPercentYearly / 100;
            int years = 0;

            while (amountOfPeopleInYear < goalPopulation)
            {
                double newAmountOfPeopleInYear = (amountOfPeopleInYear + (amountOfPeopleInYear * increaseByYear) + additionalPeopleYearly);
                amountOfPeopleInYear = (int)newAmountOfPeopleInYear;
                years++;
            }
            return years;
        }
    }
}
