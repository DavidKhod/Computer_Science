using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14
{
    class Program
    {
        static bool PerfectNum (int Num)
        {
            int i = 1;
            int Sum = 0;
            while (i < Num)
            {
                if (Num % i == 0)
                {
                    Sum += i;
                }
            }
            if (Sum == Num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int Num;
            Console.WriteLine("Enter a number (1-1000)");
            Num = int.Parse(Console.ReadLine());
            if (PerfectNum(Num) == true)
            {
                Console.WriteLine("Perfect num");
            }
            else
            {
                Console.WriteLine("Not perfect num");
            }
        }
    }
}
