using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Program
    {
        //Entry Claim: The function gets a positive number
        //Exit Claim: The function returns the amount of even numbers there is within the number it self
        static int EvenNums (int Num)
        {
            int Count = 0;
            while (Num != 0)
            {
                if (Num % 10 % 2 == 0)
                {
                    Count++;
                }
                Num /= 10;
            }
            return Count;
        }
        static void Main(string[] args)
        {
            int Num;
            Console.Write("Enter a number: ");
            Num = int.Parse(Console.ReadLine());
            Console.WriteLine($"The amount of even numbers within this number is {EvenNums(Num)}");
            Console.WriteLine("----------");
            int n, num;
            int Count = 0, Maxcount = 0;
            int Maxnum = 0;
            Console.WriteLine("Enter the amount of numbers you want to check");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter a number");
                num = int.Parse(Console.ReadLine());
                Count = EvenNums(num);
                if (Count > Maxcount)
                {
                    Maxcount = Count;
                    Maxnum = num;
                }
            }
            Console.WriteLine($"The number with the biggest amount of even numbers within it is {Maxnum}");

        }
    }
}
