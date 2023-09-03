using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWQ6_8_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int kid1, kid2,difference;
            Console.WriteLine("Enter the age of the first brother");
            kid1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the age of the second brother");
            kid2 = int.Parse(Console.ReadLine());
            difference = Math.Abs(kid1 - kid2);
            Console.WriteLine("The difference between the ages is "+difference);
        }
    }
}
