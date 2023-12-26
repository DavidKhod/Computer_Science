using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q16_1_12_22
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 35; i++)
            {
                int num1, num2;
                Console.WriteLine("Enter two numbers: ");
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                if (num1>num2)
                {
                    num1 = num1 - 1;
                    num2 = num2 + 1;
                    Console.WriteLine($"{num2},{num1}");
                }
                else if (num1<num2)
                {
                    num2 = num2 - 1;
                    num1 = num1 + 1;
                    Console.WriteLine($"{num1},{num2}");
                }
                else
                {
                    Console.WriteLine("They are equal");
                }
            }
        }
    }
}
