using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q36
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2, Sum = 0;
            int result=1;
            Console.WriteLine("Enter a number");
            Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number");
            Num2 = int.Parse(Console.ReadLine());
            if (Num1>Num2)
            {
                for (int i = Num2; i <= Num1; i++)
                {
                    Sum += i;
                    result *= i;
                }
            }
            else 
            {
                for (int i = Num1; i <= Num2; i++)
                {
                    Sum += i;
                    result *= i;
                }
            }
            Console.WriteLine($"The sum of the numbers between this is {Sum}");
            Console.WriteLine($"The idk of the numbers between {Num1} and {Num2} is {result}");

        }
    }
}
