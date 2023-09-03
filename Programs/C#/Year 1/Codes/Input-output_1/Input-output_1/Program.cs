using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_output_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Angle1, Angle2, Angle3 = 0;
            Console.WriteLine("Enter the first angle");
            Angle1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second angle");
            Angle2 = double.Parse(Console.ReadLine());
            Console.WriteLine("The 3rd angle is " + (180-(Angle1 + Angle2)));
             

        }
    }
}
