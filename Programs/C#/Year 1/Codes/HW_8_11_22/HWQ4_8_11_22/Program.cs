using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWQ4_8_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1,slant;
            Console.WriteLine("Enter the first side of the square");
            side1 = double.Parse(Console.ReadLine());
            slant = (Math.Pow(side1, 2))+(Math.Pow(side1, 2));
            slant = Math.Sqrt(slant);
            Console.WriteLine("The slant in the square is "+slant);
        }
    }
}
