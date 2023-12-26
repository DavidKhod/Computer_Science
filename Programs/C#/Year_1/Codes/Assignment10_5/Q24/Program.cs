using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q24
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFirst = 0, Numsecond = 1, Sum = 0, n;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());
            while (numFirst + Numsecond < n)
            {
                Sum = numFirst + Numsecond;
                Numsecond = numFirst;
                numFirst = Sum;
                if (Sum > n)
                {
                    Sum = n + 1;
                }
                else
                {
                    Console.WriteLine(Sum);
                }
            }
        }
    }
}
