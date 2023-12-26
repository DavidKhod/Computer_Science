using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerWithPassport
{
    class Program
    {
        static Date GenerateRandomizedDate()
        {
            Random rnd = new Random();
            int year = rnd.Next(2000, 2024);
            int month = rnd.Next(1, 13);
            int day = 0;
            if (year % 4 == 0)
            {
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    day = rnd.Next(1, 32);
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    day = rnd.Next(1, 31);
                }
                else
                {
                    day = rnd.Next(1, 30);
                }
            }
            else
            {
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    day = rnd.Next(1, 32);
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    day = rnd.Next(1, 31);
                }
                else
                {
                    day = rnd.Next(1, 29);
                }
            }
            Date d1 = new Date(day, month, year);
            return d1;
        }
        static void Main(string[] args)
        {
            Date d1 = GenerateRandomizedDate();
            Passport p1 = new Passport();
            Console.Write($"Enter you name: ");
            p1.Name = Console.ReadLine();
            Console.Write($"Enter your passport number: ");
            p1.Number = int.Parse(Console.ReadLine());
            p1.ExpiryDate = d1;
            Console.WriteLine($"{p1.ToString()}");
            Travler t1 = new Travler();
            t1.ETPassport = p1;
            t1.ETHasPaid = false;
            Console.WriteLine($"{t1.ToString()}");
            t1.Pay();
            Console.WriteLine($"{t1.ToString()}");
        }
    }
}
