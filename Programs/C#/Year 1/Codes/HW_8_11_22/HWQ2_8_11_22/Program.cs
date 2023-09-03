using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWQ2_8_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double Base,height,volume;
            Console.WriteLine("Enter the base of the cube");
            Base = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height");
            height = double.Parse(Console.ReadLine());
            volume = (Base*Base*height);
            Console.WriteLine("The volume of the cube is "+volume);
        }
    }
}
