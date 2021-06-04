using System;

namespace GrowthOfPopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingPopulation = 1000;
            double growthInPercentYearly = 0.02;
            int additionalPeopleYearly = 50;
            int goalPopulation = 1200;

            Console.WriteLine("It takes {0} years until you reach your goal population", NbYear(startingPopulation, growthInPercentYearly, additionalPeopleYearly, goalPopulation));
        }

        public static int NbYear(int startingPopulation, double growthInPercentYearly, int additionalPeopleYearly, int goalPopulation)
        {
            int amountOfPeopleInYear = startingPopulation;
            int years = 0;

            while (amountOfPeopleInYear < goalPopulation)
            {
                amountOfPeopleInYear = CalculateAmountOfPeopleEndOfYear(amountOfPeopleInYear, growthInPercentYearly, additionalPeopleYearly);
                years++;
            }
            return years;

            static int CalculateAmountOfPeopleEndOfYear (int amountOfPeopleInYear, double growthInPercentYearly, int additionalPeopleYearly)
            {
                double NewAmountOfPeopleEndOfYear = (double)amountOfPeopleInYear + ((double)amountOfPeopleInYear * growthInPercentYearly) + additionalPeopleYearly;
                return (int)NewAmountOfPeopleEndOfYear;
            }
        }
    }
}
