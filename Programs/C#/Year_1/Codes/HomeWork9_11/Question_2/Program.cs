using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int Max = 10, Min = 99;
            for (int i = 1; i <= 100; i++)
            {
                int num;
                num = rnd.Next(10,100);
                if (num>Max)
                {
                    Max = num;
                }
                if (num<Min)
                {
                    Min = num;
                }
            }
            Console.WriteLine($"The smallest number is {Min}");
            Console.WriteLine($"The biggest number is {Max}");
        }
    }
}
