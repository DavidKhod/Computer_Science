using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q35
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());
            int SumEven=0, SumOdd=0;
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    SumEven += i;
                }
                else
                {
                    SumOdd += i;
                }
            }
            Console.WriteLine($"The sum of even numbers is {SumEven}");
            Console.WriteLine($"The sum of odd numbers is {SumOdd}");
            Console.WriteLine($"The difference between the numbers is {Math.Abs(SumEven-SumOdd)}");
        }
    }
}
