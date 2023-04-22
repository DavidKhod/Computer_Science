using System;

namespace P77Q46
{
    class Program
    {
        /// <summary>
        /// The function Find in the array of Dates, what is the Date that appears the most times
        /// </summary>
        /// <param name="Dates">The array of Dates looking through</param>
        /// <returns>The Date that appears the most times in the array of Dates inputed</returns>
        static Date DateWithMostBD(Date[] Dates)
        {
            int[] DatesCnt = new int[Dates.Length];
            for (int i = 1; i < Dates.Length; i++)
            {
                for (int j = 1; j < Dates.Length; j++)
                {
                    if (Dates[i] == Dates[j])
                    {
                        DatesCnt[i]++;
                    }
                }
            }
            for (int i = 1; i < DatesCnt.Length; i++)
            {
                bool BiggerThanOther = true;
                for (int j = 1; j < DatesCnt.Length && BiggerThanOther == true; j++)
                {
                    if (DatesCnt[i] < DatesCnt[j])
                    {
                        BiggerThanOther = false;
                    }
                }
                if (BiggerThanOther)
                {
                    return Dates[i];
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            int amountOfdates;
            Console.Write("Enter the amount of dates: ");
            amountOfdates = int.Parse(Console.ReadLine());
            Date[] Dates = new Date[amountOfdates + 1];
            for (int i = 1; i < Dates.Length; i++)
            {
                int day, month, year;
                Console.WriteLine("Enter the day/month/year: ");
                day = int.Parse(Console.ReadLine());
                month = int.Parse(Console.ReadLine());
                year = int.Parse(Console.ReadLine());
                Date date = new Date(day, month, year);
                Dates[i] = date;
            }
            Console.WriteLine($"The date with the biggest amount of Birthdays is: {DateWithMostBD(Dates).ToString()}");
        }
    }
}
