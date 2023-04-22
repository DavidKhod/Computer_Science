using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWQ2_11_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We take a roll for each of the sides of the triangle to check if its possible");
            Random rd = new Random();
            int Side1 = rd.Next(1, 31);
            Random rnd = new Random();
            int Side2 = rd.Next(1, 31);
            Random red = new Random();
            int Side3 = rd.Next(1, 31);
            Console.WriteLine("The first side is "+Side1);
            Console.WriteLine("The second side is " + Side2);
            Console.WriteLine("The third side is " + Side3);
            if (Side1+Side2>Side3 && Side1+Side3>Side2 && Side3+Side2>Side1)
            {
                Console.WriteLine("The trianle appears to be possible");
            }
            else
            {
                Console.WriteLine("The triangle appears to be impossible");
            }
        }
    }
}
