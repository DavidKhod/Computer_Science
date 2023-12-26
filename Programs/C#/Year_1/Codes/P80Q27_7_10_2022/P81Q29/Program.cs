using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P81Q29
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter a number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            num3 = int.Parse(Console.ReadLine());
            if ((num1*num1)+(num2*num2)==(num3*num3)|| (num1 * num1) + (num3 * num3) == (num2 * num2)|| (num3 * num3) + (num2 * num2) == (num1 * num1))
            {
                Console.WriteLine(num1+"^2 + "+num2+"^2 = "+num3+"^2");
            }
            else
            {
                Console.WriteLine("The numbers do not make a pithegoras equation");
            }
        }
    }
}
