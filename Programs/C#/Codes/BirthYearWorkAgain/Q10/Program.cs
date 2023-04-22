using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            int C1, C2, C3,COne,CTwo,CThree;
            Console.Write("Enter the amout of cups 1 :");
            C1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the amount of cups 2 :");
            C2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the amount of cups 3 :");
            C3 = int.Parse(Console.ReadLine());
            COne = C1 * 10;
            CTwo = C2 * 100;
            CThree = C3 * 1000;
            Console.WriteLine("The amount of points you got is "+(COne+CTwo+CThree));
        }
    }
}
