using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_Plus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,num1,num2,num3;
            Console.WriteLine("Enter a number");
            num = int.Parse(Console.ReadLine());
            num1 = num + 1;
            num2 = num1 + 1;
            num3 = num2 + 1;
            Console.WriteLine("The numbers are "+ num1 +", "+ num2 +", "+ num3 + ".");
        }
    }
}
