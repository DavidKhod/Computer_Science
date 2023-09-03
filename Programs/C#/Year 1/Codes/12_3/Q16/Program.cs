using System;

namespace Q16
{
    class Program
    {
        // Entry claim: the function gets  full positive number
        // Exit claim: the functions returns the sum of the number's digits
        static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        //Entry claim: The function gets a full positive number
        //Exit claim: The function prints the numbers that their sum of digits equals to the sum digit of num
        static void SmallerNumEqSum(int num)
        {
            int sumNum = SumOfDigits(num);
            for (int i = 1; i < num; i++)
            {
                if (SumOfDigits(i) == sumNum)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            SmallerNumEqSum(num);
        }
    }
}
