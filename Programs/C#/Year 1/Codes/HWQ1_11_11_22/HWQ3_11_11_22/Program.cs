using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWQ3_11_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We randomize thw width and length of a rectangle");
            Random rd = new Random();
            int Width = rd.Next(10,50);
            Random rnd = new Random();
            int Length = rd.Next(Width+1, 51);
            Console.WriteLine("The length is "+Length);
            Console.WriteLine("The width is "+Width);

        }
    }
}
