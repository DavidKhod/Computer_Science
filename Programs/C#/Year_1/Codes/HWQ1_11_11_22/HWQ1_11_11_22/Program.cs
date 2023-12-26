using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWQ1_11_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Two dice rolls were made");
            Random rd = new Random();
            int Throw1 = rd.Next(1, 7);
            Random rnd = new Random();
            int Throw2 = rd.Next(1, 7);
            Console.WriteLine("The first roll was "+Throw1);
            Console.WriteLine("The second roll was "+Throw2);
            if (Throw1==Throw2)
            {
                Console.WriteLine("The rolls were the same(double roll)");
            }
            else
            {
                if (Throw1==5 && Throw2==6 || Throw1==6 && Throw2 == 5)
                {
                    Console.WriteLine("Its shesh besh");
                }
                else
                {
                    Console.WriteLine("The roll were just different");
                }
            }
        }
    }
}
