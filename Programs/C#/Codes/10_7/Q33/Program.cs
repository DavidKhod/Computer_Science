using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q33
{
    class Program
    {
        static void Main(string[] args)
        {
            double Num = 1,BackNum;
            string Number = "";
            Console.WriteLine("Enter a number");
            BackNum = double.Parse(Console.ReadLine());
            while (Num > 0)
            {
                Console.WriteLine("Enter another number");
                Num = double.Parse(Console.ReadLine());
                if (Num != 0)
                {
                    if (Num < BackNum)
                    {
                        Number += $" |{BackNum}, {Num}|";
                    }
                }
                BackNum = Num;
            }
            Console.WriteLine(Number);
        }
    }
}
