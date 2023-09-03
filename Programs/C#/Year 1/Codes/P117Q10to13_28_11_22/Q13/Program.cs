using System;

namespace Q13
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 25; i++)
            {
                int TwoDigitnum;
                Console.Write("Enter a two digit number: ");
                TwoDigitnum = int.Parse(Console.ReadLine());
                int FirstDigit, SecondDigit;
                FirstDigit = TwoDigitnum / 10;
                SecondDigit = TwoDigitnum % 10;
                if (FirstDigit % 2 == 0 && SecondDigit % 2 == 0)
                {
                    Console.WriteLine($"{TwoDigitnum} --> Both of the numbers are even");
                }
                else if (FirstDigit % 2 != 0 && SecondDigit % 2 != 0)
                {
                    Console.WriteLine($"{TwoDigitnum} --> Both of the numbers are odd");
                }
                else if ((FirstDigit % 2 == 0 && SecondDigit % 2 != 0)|| (FirstDigit % 2 != 0 && SecondDigit % 2 == 0))
                {
                    Console.WriteLine($"{TwoDigitnum} --> one number is even and the second is odd");
                }
                
            }
        }
    }
}
