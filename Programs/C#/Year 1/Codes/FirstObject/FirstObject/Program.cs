using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(10, "Blue");
            Console.WriteLine(c1.ToString());

            Circle c2 = new Circle(50, "Yellow");
            Console.WriteLine(c2.ToString());

            c1.SetColor("Red");
            c1.SetRadius(500);
            Console.WriteLine(c1.ToString());
        }
    }
}
