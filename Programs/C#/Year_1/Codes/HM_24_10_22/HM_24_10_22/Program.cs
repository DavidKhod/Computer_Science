using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_24_10_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter a number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            num3 = int.Parse(Console.ReadLine());
            if (num1<=num2&&num1<=num3)
            {
                Console.WriteLine("The smallest number is "+num1);
            }
            else if (num2<=num1&num2<=num3)
            {
                Console.WriteLine("The smallest number is "+num2);
            }
            else if (num3<=num1&&num3<=num2)
            {
                Console.WriteLine("The smallest number is "+num3);
            }

        }
    }
}
