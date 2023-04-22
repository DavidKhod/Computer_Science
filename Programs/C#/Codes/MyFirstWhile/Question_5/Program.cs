using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, Count = 0;
            Console.WriteLine("Enter a pair of numbers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            if (!((num1 == 0 && num2 == 0) || num1 == 0 || num2 == 0))
            {
                if (num1 == num2)
                {
                    Count++;
                }
            }
            while (!((num1 == 0 && num2 == 0) || num1 == 0 || num2 == 0))
            {
                Console.WriteLine("Enter a pair of numbers");
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                if (num1 == num2)
                {
                    Count++;
                }
            }
            Console.WriteLine($"The amount of equal numbers is {Count}");
        }
    }
}
