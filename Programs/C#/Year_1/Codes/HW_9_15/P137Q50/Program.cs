using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P137Q50
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,Sum=0;
            Console.WriteLine("Enter the number you want the loop to work until");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Sum += i;
            }
            Console.WriteLine($"The sum of the number until {n} is {Sum}");
        }
    }
}
