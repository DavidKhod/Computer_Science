using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurtion
{
    class Program
    {
        static int factorial(int n)
        {
            if (n == 0)
                return 1;
            return factorial(n - 1) * n;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number for a factorial: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(factorial(num));
            
        }
    }
}