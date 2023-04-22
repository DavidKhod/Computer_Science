using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFiftynineQFife
{
    class Program
    {
        static void Main(string[] args)
        {
            double Minutes, Hours,remains;
            Console.WriteLine("Enter the amount of minutes");
            Minutes = double.Parse(Console.ReadLine());
            Hours = Minutes / 60 ;
            remains = Minutes % 60;
            Console.WriteLine("The amount of time is "+Hours+" hours And "+remains+" Minutes");
        }
    }
}
