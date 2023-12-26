using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q43
{
    class Program
    {
        static void Main(string[] args)
        {
            double zela1, zela2, zela3;
            Console.WriteLine("Enter the length of the First side");
            zela1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the Second side");
            zela2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the Third side");
            zela3= double.Parse(Console.ReadLine());
            if (zela1 == zela2 && zela2 == zela3)
            {
                Console.WriteLine("The triangle is an Equilateral triangle");
            }
            else
            {
                if (zela1 == zela2 || zela1 == zela3 || zela2 == zela3)
                {
                    Console.WriteLine("The triangle is an isosceles triangle");
                }
                else
                    Console.WriteLine("The triangle is an scalene triangle");
            }

        }
    }
}
