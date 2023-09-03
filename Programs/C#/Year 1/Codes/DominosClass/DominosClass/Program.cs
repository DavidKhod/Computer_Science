using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominosClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Domino D1 = new Domino();
            Console.WriteLine($"{D1.GetSide1()}");
            Console.WriteLine($"{D1.GetSide2()}");
            Console.WriteLine($"{D1.ToString()}\n");

            Domino D2 = new Domino();
            Console.WriteLine($"{D2.GetSide1()}");
            Console.WriteLine($"{D2.GetSide2()}");
            Console.WriteLine($"{D2.ToString()}\n");
            Console.WriteLine($"{D1.IsConnectable(D2)}");
        }
    }
}
