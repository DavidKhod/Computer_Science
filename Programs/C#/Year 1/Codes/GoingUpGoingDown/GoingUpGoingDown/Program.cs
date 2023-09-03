
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoingUpGoingDown
{
    class Program
    {
        static void Main(string[] args)
        {
            Double num1, num2, subtraction;
            Console.WriteLine("Entet a number");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            num1 = double.Parse(Console.ReadLine());
            if (num2>num1)
            {
                Console.WriteLine(num2+" "+num1);
                subtraction = num2 - num1;
                Console.WriteLine("The subtraction of the numbers is "+subtraction);
            }
            else
            {
                Console.WriteLine(num1+" "+num2);
                subtraction = num1 - num2;
                Console.WriteLine("The subtraction of the numbers is "+subtraction);
            }
        }
    }
}
