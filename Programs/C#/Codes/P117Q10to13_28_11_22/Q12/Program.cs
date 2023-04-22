using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            int BigNum, SmallNum;
            Console.Write("Enter the Smaller number: ");
            SmallNum = int.Parse(Console.ReadLine());
            Console.Write("Enter the bigger number: ");
            BigNum = int.Parse(Console.ReadLine());
            for (int i = SmallNum; i <= BigNum; i++)
            {
                Console.WriteLine(i);
            }
            // Part 2
            int num1, num2;
            Console.Write("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            num2 = int.Parse(Console.ReadLine());
            if (num1>num2)
            {
                for (int i = num2; i <= num1; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (num2>num1)
            {
                for (int i = num1; i <= num2; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("The number are equal");
            }
        }
    }
}
