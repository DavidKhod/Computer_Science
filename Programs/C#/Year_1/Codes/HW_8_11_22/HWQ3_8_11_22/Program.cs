using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWQ3_8_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1, side2, bigger, area;
            Console.WriteLine("Enter the first side");
            side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second side");
            side2 = double.Parse(Console.ReadLine());
            bigger = Math.Max(side1, side2);
            area = (bigger * 4);
            Console.WriteLine("The area of the square is "+area);
        }
    }
}
