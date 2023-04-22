using System;

namespace P137Q49
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberAmount = 0;
            for (int i = 1; i <= 10; i++)
            {
                int Num, FirstDigit, SecondDigit, ThirdDigit, DigitSum;
                Console.WriteLine("Enter a three digit number");
                Num = int.Parse(Console.ReadLine());
                FirstDigit = Num / 100;
                SecondDigit = (Num / 10) % 10;
                ThirdDigit = Num % 10;
                DigitSum = FirstDigit + SecondDigit + ThirdDigit;
                if (Num % DigitSum == 0)
                {
                    NumberAmount++;
                }
            }
            Console.WriteLine($"The amount of numbers that the number devided by their digit sum equals to zero is {NumberAmount}");
        }
    }
}
