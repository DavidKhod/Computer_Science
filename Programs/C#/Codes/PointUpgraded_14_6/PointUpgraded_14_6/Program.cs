using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointUpgraded_14_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Point Point1 = new Point(10, 15);
            Point Point2 = new Point(50, 30);
            Console.WriteLine($"{Point1.ToString()}");
            Console.WriteLine($"{Point2.ToString()}");
            Console.WriteLine($"{Point1.GetSN()}");

        }
    }
}
