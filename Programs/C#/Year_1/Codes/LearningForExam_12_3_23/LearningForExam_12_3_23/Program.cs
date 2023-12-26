using System;

namespace LearningForExam_12_3_23
{

    class Program
    {
        static Random rnd = new Random();

        //Entry claim: The function inputs two Date class
        //Exit claim: The function return the Earlier Date between the Dates inputed
        static Date FindEarlierDate(Date date1, Date date2)
        {
            if (date1.GetYear() < date2.GetYear())
            {
                return date1;
            }
            else if (date1.GetYear() > date2.GetYear())
            {
                return date2;
            }
            if (date1.GetMonth() < date2.GetMonth())
            {
                return date1;
            }
            else if (date1.GetMonth() > date2.GetMonth())
            {
                return date2;
            }
            if (date1.GetDay() < date2.GetDay())
            {
                return date1;
            }
            else if (date1.GetDay() > date2.GetDay())
            {
                return date2;
            }
            return date1;
        }

        //Entry claim: The function inputes Two Dates
        //Exit claim: The function returns The latest leap year in between the Dates inputed
        static int FindLatestLeapYear(Date Date1, Date Date2)
        {
            Date min = Date1.EarlierDate(Date2);
            Date max = new Date(0, 0, 0);
            if (Date1.EarlierDate(Date2) == Date1)
            {
                max = Date2;
            }
            else
            {
                max = Date1;
            }
            for (int i = max.GetYear(); i <= min.GetYear(); i--)
            {
                if (i % 4 == 0)
                {
                    return i;
                }
            }
            return 0;
        }

        /// <summary>
        /// Creates a Date from the user's input(day,month,year)
        /// </summary>
        /// <returns>A Date with the user's input</returns>
        static Date CreateDate()
        {
            int day, month, year;
            Console.Write("Enter Day: ");
            day = int.Parse(Console.ReadLine());
            Console.Write("Enter Month: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Enter Year: ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Date CreatedDate = new Date(day, month, year);
            return CreatedDate;
        }

        /// <summary>
        /// Finds if the Dates created within the Function are in a rising order
        /// </summary>
        /// <param name="n">The amount of Dates to Create</param>
        /// <returns>True if the Dates are in a rising order,False if the Dates are not in a rising order</returns>
        static bool IsRaisingOrder(int n)
        {
            Date Before = CreateDate();
            for (int i = 1; i <= n - 1; i++)
            {
                Date After = CreateDate();
                Date AfterBefore = Before.NextDay();
                if (AfterBefore.CompareTo(After) != 0)//If the Dates are not the same
                {
                    return false;
                }
                Before = After;
            }
            return true;
        }

        /// <summary>
        /// Count The amount of Date serieses that are rising
        /// </summary>
        /// <param name="n">The Amount of Date Serieses to Check</param>
        /// <returns>The amount of Date serieses that are in a rising order</returns>
        static int RisingOrderCount(int n)
        {
            int cntRisingOrders = 0;
            for (int i = 1; i <= n; i++)
            {
                bool RisingOrder = true;
                Date Before = CreateDate();
                while (Before.GetYear() != 0)
                {
                    Date After = CreateDate();
                    if (After.GetYear() != 0)
                    {
                        Date AfterBefore = Before.NextDay();
                        if (AfterBefore.CompareTo(After) != 0)//If the Dates are not the same
                        {
                            RisingOrder = false;
                        }
                    }
                    Before = After;
                }
                if (RisingOrder)
                {
                    cntRisingOrders++;
                }
                if (i <= n)
                {
                    Console.WriteLine("--------------------Next series--------------------");
                }
            }
            return cntRisingOrders;
        }

        static void Main(string[] args)
        {
            Date date1 = new Date(7, 3, 2007);
            Console.WriteLine($"Date 1: {date1.ToString()}\n");

            Date date2 = new Date(18, 1, 2007);
            Console.WriteLine($"Date 2: {date2.ToString()}\n");

            Date dateCopy = new Date(date1);
            Console.WriteLine($"Copy Date 1: {date1.ToString()}\n");

            Console.WriteLine($"Compare Date 1 To Date 2: {date1.EarlierDate(date2)}\n");

            Console.WriteLine($"Date 1 Next Day: {date1.NextDay()}");
            Console.WriteLine($"Date 2 Next Day: {date2.NextDay()}\n");

            Console.WriteLine($"The Earlier date between date 1 and date 2: {FindEarlierDate(date1, date2)}\n");

            Date RndDate1 = new Date(rnd.Next(1, 31), rnd.Next(1, 13), rnd.Next(1998, 2023));
            Date RndDate2 = new Date(rnd.Next(1, 31), rnd.Next(1, 13), rnd.Next(1998, 2023));
            Console.WriteLine($"Random Date 1:{RndDate1.ToString()}");
            Console.WriteLine($"Random Date 2:{RndDate2.ToString()}\n");

            Console.WriteLine($"The latest leap year in between Random Date 1 and Random Date 2:{FindLatestLeapYear(RndDate1, RndDate2)}\n");

            int n;
            Console.Write("Enter How many Dates To Create: ");
            n = int.Parse(Console.ReadLine());

            if (IsRaisingOrder(n) == true)
            {
                Console.WriteLine("The Dates are in a rising order\n");
            }
            else
            {
                Console.WriteLine("The Dates are not in a rising order\n");
            }

            Console.WriteLine(RisingOrderCount(5));
        }
    }
}
