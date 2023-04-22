using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            for (int i = 1; i <= 25; i++)
            {
                int Num1, Num2, Num3;
                double average;
                Console.WriteLine("Enter three numbers");
                Num1 = int.Parse(Console.ReadLine());
                Num2 = int.Parse(Console.ReadLine());
                Num3 = int.Parse(Console.ReadLine());
                average = (Num1+Num2+Num3) / 3;
                Console.WriteLine($"The average is {average}");
                if (average > 0)
                {
                    j++;
                }
            }
            Console.WriteLine($"The amount of numbers that their average is a positive number is {j}");
        }
    }
}
