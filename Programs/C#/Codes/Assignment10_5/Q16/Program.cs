using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q16
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = 1, Sum = 0;
            while (Sum < 500)
            {
                Sum += Num * Num;
                if (Sum > 500)
                {
                    Console.Write($"{Num}^2 = {Sum}\n");
                }
                else
                {
                    Console.Write($"{Num}^2 + ");
                }
                Num++;
            }
        }
    }
}
