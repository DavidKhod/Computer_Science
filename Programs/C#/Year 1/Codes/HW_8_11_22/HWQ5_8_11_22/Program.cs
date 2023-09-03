using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWQ5_8_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double height1, width1, height2, width2, area1, area2,BiggerArea;
            Console.WriteLine("Enter the height of the first rectangle");
            height1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the widdth of the first rectangle");
            width1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the second rectangle");
            height2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the widdth of the second rectangle");
            width2 = double.Parse(Console.ReadLine());
            area1 = width1 * height1;
            area2 = height2 * width2;
            BiggerArea = Math.Max(area1, area2);
            Console.WriteLine("THe bigger area is "+BiggerArea);
        }
    }
}
