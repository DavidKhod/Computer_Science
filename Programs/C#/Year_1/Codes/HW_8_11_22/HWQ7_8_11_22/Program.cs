using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWQ7_8_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int kid1, kid2, kid3, bigger, difference, smaller;
            Console.WriteLine("Enter the age of the first brother");
            kid1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the age of the second brother");
            kid2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the age of the third brother");
            kid3 = int.Parse(Console.ReadLine());
            bigger = Math.Max(kid1, kid2);
            bigger = Math.Max(bigger,kid3);
            smaller = Math.Min(kid1, kid2);
            smaller = Math.Min(smaller, kid3);
            difference = bigger - smaller;
            Console.WriteLine("The difference between the ages is " + difference);
        }
    }
}
