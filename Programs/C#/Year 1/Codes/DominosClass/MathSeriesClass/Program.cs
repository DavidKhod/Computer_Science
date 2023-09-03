using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSeriesClass
{
    class Program
    {
        static void mathSeries(double firstnum, double diff, int numAmount)
        {
            
            double num = firstnum;
            for (int i = 1; i <= numAmount; i++)
            {
                num += diff;
            }
            Console.WriteLine($"{num}");
            num += 1;
            Console.WriteLine($"after adding one {num}");
        }

        static void Main(string[] args)
        {
            //Task A
            MathSeries m1 = new MathSeries(0, 3, 5);
            m1.SetNumAmount(10);
            Console.WriteLine($"{m1.ToString()}\n");
            //Task B
            mathSeries(7, 8, 3);
        }
    }
}
