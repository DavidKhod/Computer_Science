using System;

namespace CountNumberLengthRecurtion
{
    class Program
    {
        static int CountLength(int num)
        {
            if (num / 10 == 0)//if its a one digit number
                return 1;
            //if the number has two digits, meaning x>=10 
            return CountLength(num / 10) + 1;
        }

        static int CountEvenDigits(int num)
        {
            if (num / 10 == 0)
            {
                if (num % 2 == 0)//if the number is even return 1 else return 0
                    return 1;
                else
                    return 0;
            }
            else
            {
                int temp = 0;
                if (num % 2 == 0)//Check if the current number is even or odd
                    temp = 1;
                return CountEvenDigits(num / 10) + temp;
            }
        }

        static int CountOddDigits(int num)
        {

            if (num / 10 == 0)
            {
                if (num % 2 != 0)//if the number is odd return 1 else return 0
                    return 1;
                else
                    return 0;
            }
            else
            {
                int temp = 0;
                if (num % 2 != 0)//Check if the current number is even or odd
                    temp = 1;
                return CountOddDigits(num / 10) + temp;
            }
        }

        static int SumOfDigits(int num)
        {
            num = Math.Abs(num);
            if (num / 10 == 0)
                return num;
            else
                return SumOfDigits(num / 10) + num % 10;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"The length of the number is: {CountLength(num)}");
            Console.WriteLine($"The amount of even numbers is: {CountEvenDigits(num)}");
            Console.WriteLine($"The amount of odd numbers is: {CountOddDigits(num)}");
            Console.WriteLine($"The sum of all digits is: {SumOfDigits(num)}");
        }
    }
}
