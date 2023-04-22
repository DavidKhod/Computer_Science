using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjFirstMbt1;

namespace ClassWork_20_11_22
{
    class Program
    {
        static void Main(string[] args)//Circle
        {
            Double Rad1;
            string Color1;
            Console.WriteLine("Enter the radius of the circle");
            Rad1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the color of the circle");
            Color1 = Console.ReadLine();
            Circle Circle1 = new Circle(Rad1,Color1);
            Circle Circle2 = new Circle(10,"Blue");
            Console.WriteLine(Circle1);
            Console.WriteLine(Circle2);
            Circle2.SetRadius(Circle1.GetRadius() + Circle2.GetRadius());
            Circle1.SetRadius(Circle1.GetRadius()+1);
            Console.WriteLine(Circle1);
            Console.WriteLine(Circle2);
        }
    }
}
