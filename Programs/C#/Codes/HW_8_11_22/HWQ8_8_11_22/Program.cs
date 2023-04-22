using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWQ8_8_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches,centimeters;
            Console.WriteLine("Enter the length in inches");
            inches = double.Parse(Console.ReadLine());
            centimeters = Math.Round(inches * 2.54);
            Console.WriteLine("The length in centimeters is about "+centimeters+" centimeters");
        }
    }
}
