using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double side,volume;
            Console.WriteLine("Enter the length of the side");
            side = double.Parse(Console.ReadLine());          
            volume=Math.Pow(side,3);
            Console.WriteLine("The volume of the cube is "+volume);
        }
    }
}
