using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P80Q31
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3;
            Console.WriteLine("Enter a number");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a third number");
            num3 = double.Parse(Console.ReadLine());
            if ((num1+num2>num3)&&(num1+num3>num2)&&(num2+num3>num1))
            {
                //Console.WriteLine("All three of the numbers can be the length of the ribs");
                Console.WriteLine("Can be a triangle");
            }
            else
            {
                //Console.WriteLine("Those three numbers cannot be the length of the ribs");
                Console.WriteLine("Cannot be a triangle");
            }
        }
    }
}
