using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11
{
    class Program
    {
        static void Main(string[] args)
        {
            double TP,DP;
            Console.WriteLine("Enter the price of the Trip");
            TP = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the dollar rate");
            DP = double.Parse(Console.ReadLine());
            Console.WriteLine("The sum of trip in shekels is "+(TP * DP+400*DP));
        }
    }
}
