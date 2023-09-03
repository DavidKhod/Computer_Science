using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            double angleBass;
            Console.WriteLine("Enter the bass angle");
            angleBass = double.Parse(Console.ReadLine());
            Console.WriteLine("The head angle is " + (180 - (angleBass*2)));

        }
    }
}
