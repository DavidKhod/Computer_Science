using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,num1;
            Console.WriteLine("Enter a whole number");
            num = int.Parse(Console.ReadLine());
            if (num % 2 != 0) 
            {
                Console.WriteLine("Your number is odd");
            }
            else
            {
                Console.WriteLine("Your number is even");

            }
            while (num % 2 != 0)
            {
                Console.WriteLine("Enter another number");
                num1 = int.Parse(Console.ReadLine());
            }
        }
    }
}
