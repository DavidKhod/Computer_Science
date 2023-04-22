using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_30_9_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double length,width,area,Perimiter;
            Console.WriteLine("Enter the length of the quad");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the quad");
            width = double.Parse(Console.ReadLine());
            area = width * length;
            Perimiter = (width * 2) + (length * 2);
            Console.WriteLine("The area of the quad is "+area);
            Console.WriteLine("The scope of the quad is "+Perimiter);
            if (width == length)
            {
                Console.WriteLine("The quad is a square");
            }
            else
            {
                Console.WriteLine("The quad is not a square");
            }
        }
    }
}
