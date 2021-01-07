using System;

namespace Task03_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double startMoney = double.Parse(Console.ReadLine());
            int days = 0;
            int noSavedDaysIndex = 0;
            double sum = 0;
            while (noSavedDaysIndex < 5)
            {
                string typeOfDay = Console.ReadLine();
                double moneyPerDay = double.Parse(Console.ReadLine());
                days += 1;
                if (typeOfDay == "spend")
                {
                    noSavedDaysIndex += 1;
                    sum -= moneyPerDay;
                    if (sum < 0)
                    {
                        sum = 0;
                    }
                }
                else
                {
                    noSavedDaysIndex = 0;
                    sum += moneyPerDay;
                }
                if (sum >= neededMoney)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }
            }
            if (noSavedDaysIndex == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(days);
            }
        }
    }
}
