using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num, Units, Tens, SumAll, SumDigits;
            Console.WriteLine("Enter a two digit number");
            Num = int.Parse(Console.ReadLine());
            Units = Num % 10;
            Tens = Num / 10 % 10;
            SumDigits = Units * Tens;
            while (SumDigits != 0)
            {

            }
        }
    }
}
