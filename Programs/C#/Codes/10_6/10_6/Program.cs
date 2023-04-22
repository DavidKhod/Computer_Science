using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double Num;
            int count = 1;
            Console.WriteLine("Enter a number");
            Num = double.Parse(Console.ReadLine());
            while ((int)Num / 10 != 0)
            {
                count++;
                Num = (int)Num / 10;
            }
            Console.WriteLine(count);

        }
    }
}
