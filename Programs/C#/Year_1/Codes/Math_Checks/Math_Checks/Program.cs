using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Checks
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The first number is "+(num/10));
            Console.WriteLine("The second number is "+(num%10));
            Console.WriteLine("The thirt number is "+((num/10)%10));
            Console.WriteLine(num%10);
        }
    }
}
