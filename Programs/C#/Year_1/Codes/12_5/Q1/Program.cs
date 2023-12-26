using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjFirstMbt1;
namespace Q1
{
    class Program
    {
        static Time DiffTime(Time time1,Time time2)
        {
            int num1, num2,difference;
            num1 = time1.GetHour() * 60 + time1.GetMinutes();
            num2 = time2.GetHour() * 60 + time2.GetMinutes();
            difference = Math.Abs(num1 - num2);
            Time diffTime = new Time(difference / 60, difference % 60);
            return diffTime;
        }
        static void Main(string[] args)
        {
            int option;
            Console.WriteLine("Enter your option (1 = First Q or 2 = Second Q)");
            option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                int hour1, minutes1;
                int hour2, minutes2;
                Console.WriteLine("Enter the hour");
                hour1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the minutes");
                minutes1 = int.Parse(Console.ReadLine());
                Time Time1 = new Time(hour1, minutes1);

                Console.WriteLine("Enter the hour");
                hour2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the minutes");
                minutes2 = int.Parse(Console.ReadLine());
                Time Time2 = new Time(hour2, minutes2);

                Console.WriteLine($"{DiffTime(Time1, Time2)}");
            }
            else
            {
                int hour1, minutes1;
                int hour2, minutes2;
                Console.WriteLine("Enter the hour");
                hour1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the minutes");
                minutes1 = int.Parse(Console.ReadLine());
                Time time1 = new Time(hour1, minutes1);

                Console.WriteLine("Enter the hour");
                hour2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the minutes");
                minutes2 = int.Parse(Console.ReadLine());
                Time time2 = new Time(hour2, minutes2);

                int num1, num2, difference;
                num1 = time1.GetHour() * 60 + time1.GetMinutes();
                num2 = time2.GetHour() * 60 + time2.GetMinutes();
                difference = Math.Abs(num1 - num2);
                Time diffTime = new Time(difference / 60, difference % 60);
                Console.WriteLine(diffTime);
            }
        }
    }
}
