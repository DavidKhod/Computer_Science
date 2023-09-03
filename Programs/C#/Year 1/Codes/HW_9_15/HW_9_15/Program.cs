using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9_15
{
    class Program
    {
        static void Main(string[] args)//Question 48
        {
            int NumberAmount = 0;
            string Numbers = "";
            for (int i = 1; i <= 50; i++)
            {
                int Num, FirstDigit, SecondDigit, ThirdDigit;
                Console.WriteLine("Enter a three digit number");
                Num = int.Parse(Console.ReadLine());
                FirstDigit = Num / 100;
                SecondDigit = (Num / 10) % 10;
                ThirdDigit = Num % 10;
                if (FirstDigit == SecondDigit || SecondDigit==ThirdDigit || ThirdDigit == FirstDigit)
                {
                    Numbers += $"{Num} ";
                    NumberAmount++;
                }
            }
            Console.WriteLine($"The Numbers that have at least two equal digits are {Numbers}");
            Console.WriteLine($"The amount of numbers with at least two equal digits is {NumberAmount}");
            
        }
    }
}
