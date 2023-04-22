using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsherWantsHelp
{
    class Program
    {
        static void Main(string[] args)
        {
            double YesterdaysTemp,DaysOverAmount = 0;
            string DaysHotter = "";
            double Max = 0;
            Console.Write("Enter the temperature in day 1: ");
            YesterdaysTemp = double.Parse(Console.ReadLine());
            Max = YesterdaysTemp;
            for (int i = 2; i <= 14; i++)
            {
                double TodayTemp;
                Console.Write($"Enter the temperature in day {i}: ");
                TodayTemp = double.Parse(Console.ReadLine());
                if (TodayTemp > YesterdaysTemp)
                {
                    DaysOverAmount++;
                    DaysHotter += $" Day {i},"; 
                }
                if (TodayTemp > Max)
                {
                    Max = TodayTemp;
                }
                YesterdaysTemp = TodayTemp;
            }
            Console.WriteLine($"The amount of days that were hotter then the one befoe them is {DaysOverAmount}");
            Console.WriteLine($"And the days are {DaysHotter}");
            Console.WriteLine($"The hottest temperature is {Max}");
        }
    }
}
