using System;

namespace Q19_1_12_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int TodaysTemperature1;
            Console.Write("Enter today's temperature (day 1): ");
            TodaysTemperature1 = int.Parse(Console.ReadLine());
            for (int i = 2; i <=30; i++)
            {
                int TodaysTemperature2;
                Console.Write($"Enter today's temperature(day {i}): ");
                TodaysTemperature2 = int.Parse(Console.ReadLine());
                if (TodaysTemperature1<TodaysTemperature2)
                {
                    Console.WriteLine(i);
                }
                TodaysTemperature1 = TodaysTemperature2;
            }
        }
    }
}
