using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            int Base, Height,S1,S2;
            Console.WriteLine("Enter the Base length");
            Base = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the lenght of side 1");
            S1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the lenght of side 2");
            S2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height");
            Height = int.Parse(Console.ReadLine());
            Console.WriteLine("The area of the triangle is "+(Height*Base));
            Console.WriteLine("The Scope of the triangle is "+(Base + S1 + S2));


        }
    }
}
