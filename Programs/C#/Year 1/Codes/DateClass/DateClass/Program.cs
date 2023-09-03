using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date(7, 3, 2007);
            Console.WriteLine($"{date1.ToString()}\n");
            Console.WriteLine($"{date1.GetDay()}\n");
            Console.WriteLine($"{date1.GetMonth()}\n");
            Console.WriteLine($"{date1.GetYear()}\n");

            date1.SetMonth(1);
            date1.SetDay(18);
            Console.WriteLine(date1.ToString());
            Date date2 = new Date(2, 4, 2007);
            Console.WriteLine(date2.ToString());
            Console.WriteLine($"{date1.CompareTo(date2)}");

            //חלק ב'
            //א': יודפס: 20/7/1980 
            //16/7/1963
            //ב': נוצר רק פעם אחת כי יש רק פעולה אחת של new
        }
    }
}
