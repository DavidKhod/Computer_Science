using System;

namespace Task3_2
{
    class Program
    {
        // This function finds the biggest even digit in a given integer 'num'.
        // If no even digit is found, it returns -1.
        static int BiggestEvenNum(int num)
        {
            if (num / 10 == 0)
            {
                if (num % 2 == 0)
                    return num;
                return -1;
            }
            else
            {
                int temp = BiggestEvenNum(num / 10);
                if (temp == -1 && (num % 10) % 2 == 0)
                {
                    return (num % 10);
                }
                else
                {
                    if (temp != -1 && (num % 10) % 2 == 0)
                        return Math.Max((num % 10), temp);
                    else
                        return temp;
                }
            }
        }

        // This function checks if all the digits in a given integer 'num' are either all even or all odd.
        static bool FullOfEvenOrOdd(int num)
        {
            num = Math.Abs(num);
            if (num < 10)
            {
                return true;
            }
            else
            {
                if ((((num / 10) % 10) % 2 == (num % 10) % 2))
                    return FullOfEvenOrOdd(num / 10);
                return false;
            }
        }

        // This function performs integer division (x / y) using recursion.
        static int Divide(int x, int y)
        {
            if (y == 1)
            {
                return x;
            }
            if (x < y)
            {
                return 0;
            }
            return Divide(x - y, y) + 1;
        }

        // This function calculates the remainder of integer division (x % y) using recursion.
        static int Mod(int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            return Mod(x - y, y);
        }

        // This function checks if x is a multiple of y using recursion.
        static bool IsMultipliable(int x, int y)
        {
            if (x < y)
            {
                if (x == 0)
                    return true;
                return false;
            }
            else
            {
                return IsMultipliable(x - y, y);
            }
        }

        // This function calculates the sum of odd digits from 1 to 'num' using recursion.
        static int SumOfOddDigitsUntilNum(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                if (num % 2 == 0)
                    return SumOfOddDigitsUntilNum(num - 1);
                return SumOfOddDigitsUntilNum(num - 1) * num;
            }
        }

        // This function performs multiplication of two integers 'x' and 'y' using recursion.
        static int Times(int x, int y)
        {
            if (x == 1)
            {
                return y;
            }
            else
            {
                return Times(x - 1, y) + y;
            }
        }

        static void Main(string[] args)
        {
            Console.Write($"Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"The smallest even number is: {BiggestEvenNum(num)}");

            bool allEvenOrOdd = FullOfEvenOrOdd(num);
            if (allEvenOrOdd)
                Console.WriteLine($"The number is full of Odd or Even numbers");
            else
                Console.WriteLine($"The number is not full of Odd or Even numbers");

            Console.Write("X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x}/{y} == {Divide(x, y)}");
            Console.WriteLine($"{x}%{y} == {Mod(x, y)}");

            bool multi = IsMultipliable(x, y);
            if (multi)
                Console.WriteLine($"{x}%{y} == 0");
            else
                Console.WriteLine($"{x}%{y} != 0");

            Console.WriteLine($"The sum of odd numbers from 1 to {num} is: {SumOfOddDigitsUntilNum(num)}");

            Console.WriteLine($"{x}*{y} == {Times(x, y)}");
        }
    }
}
