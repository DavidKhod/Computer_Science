using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P138Q52
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumbersAmount = 0;
            for (int i = 1; i <= 10; i++)
            {
                int Num, FirstTwoDigits, SecondTwoDigits;
                Console.WriteLine("Enter a four digit number");
                Num = int.Parse(Console.ReadLine());
                FirstTwoDigits = Num / 100;
                SecondTwoDigits = Num % 100;
                if (FirstTwoDigits == SecondTwoDigits)
                {
                    NumbersAmount++;
                }
            }
            Console.WriteLine($"The amount of number with their first two number and their second two numbers equal is {NumbersAmount}");
        }
    }
}
