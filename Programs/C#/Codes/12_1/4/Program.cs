using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        //Entry claim: The function get a number form 0 - 9, and a full positive number
        //Exit Claim: The function return the amount of times the number form 0 - 9 that it got is within the number
        static int TimesInNum (int ZeroToNine,int num)
        {
            int Count = 0;
            while (num != 0)
            {
                if (num % 10 == ZeroToNine)
                {
                    Count++;
                }
                num /= 10;
            }
            return Count;
        }
        static void Main(string[] args)
        {
            int ZeroToNine,Num1;
            Console.WriteLine("Enter a number from 0 - 9");
            ZeroToNine = int.Parse(Console.ReadLine());
            while (ZeroToNine < 0 || ZeroToNine > 9)
            {
                Console.WriteLine("Error!");
                Console.WriteLine("Enter a number from 0 - 9");
                ZeroToNine = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter a positive number");
            Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The amount of {ZeroToNine} there is in {Num1} is {TimesInNum(ZeroToNine,Num1)}");
        }
    }
}
