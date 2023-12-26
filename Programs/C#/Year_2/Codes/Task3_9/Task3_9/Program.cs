using System;

namespace Task3_9
{
    class Program
    {
        // Entry: Takes an integer `n` as input.
        // Exit: Prints the dollar symbol ('$') `n` times.
        static void PrintDollarTimes(int n)
        {
            if (n != 0)
            {
                Console.Write("$ ");
                PrintDollarTimes(n - 1);
            }
        }

        // Entry: Takes an integer `n` as input.
        // Exit: Prints numbers from `n` down to 1 and then back up to `n` in the pattern `n, n-1, ..., 1, 1, 2, ..., n`.
        static void PrintFromNumToNum(int n)
        {
            if (n != 1)
            {
                Console.Write($"{n} ");
                PrintFromNumToNum(n - 1);
                Console.Write($"{n} ");
            }
            else
            {
                Console.Write($"{n} ");
            }
        }

        // Entry: Takes an integer `n` as input.
        // Exit: Prints numbers starting from `2n`, decreasing by 2 until it reaches 2.
        static void PrintFromTimesTwotoDivTwo(int n)
        {
            if (n != 0)
            {
                Console.Write($"{n * 2} ");
                PrintFromTimesTwotoDivTwo(n - 1);
                Console.Write($"{n * 2} ");
            }
        }

        // Entry: Takes an integer `n` as input.
        // Exit: Prints numbers from 1 to `n` and then back from `n` to 1 in the pattern `1, 2, ..., n, n, n-1, ..., 1`.
        static void printFrom1ToNumAndBack(int n)
        {
            printFrom1ToNumAndBack(n, 1);
        }

        // Entry: Takes integers `n` and `i` as input.
        // Exit: Prints numbers from 1 to `n` and then back from `n` to 1 in the pattern `1, 2, ..., n, n, n-1, ..., 1`.
        static void printFrom1ToNumAndBack(int n, int i)
        {
            if (n == i)
            {
                Console.Write($"{n} {n} ");
            }
            else
            {
                Console.Write($"{i} ");
                printFrom1ToNumAndBack(n, i + 1);
                Console.Write($"{i} ");
            }
        }

        // Entry: Takes an integer `n` as input.
        // Exit: Prints the sum of numbers from `1` to `n` for each value of `n` in descending order, separated by commas.
        static void PrintSums(int n)
        {
            if (n != 0)
            {
                Console.Write($"{calcSumToNumber(n)} ");
                PrintSums(n - 1);
            }
        }

        // Entry: Takes an integer `n` as input.
        // Exit: Calculates the sum of numbers from `1` to `n` using a recursive approach and returns the result.
        static int calcSumToNumber(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + calcSumToNumber(n - 1);
            }
        }

        // Entry: Takes an integer `n` as input.
        // Exit: Prints the sum of numbers from `1` to `n` for each value of `n` in ascending order, separated by commas.
        static void PrintSums2(int n)
        {
            if (n != 0)
            {
                PrintSums2(n - 1);
                Console.Write($"{calcSumToNumber(n)} ");
            }
        }

        // Entry: Takes an integer `n` as input.
        // Exit: Prints the factorial of `n` for each value of `n` in descending order, separated by spaces.
        static void FactorialOfFactorial(int n)
        {
            if (n != 0)
            {
                FactorialOfFactorial(n - 1);
                Console.Write($"{Factorial(n)} ");
            }
        }

        // Entry: Takes an integer `n` as input.
        // Exit: Calculates the factorial of `n` using a recursive approach and returns the result.
        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("PrintDollarTimes(5):");
            PrintDollarTimes(5);
            Console.WriteLine();
            Console.WriteLine("PrintFromNumToNum(4):");
            PrintFromNumToNum(4);
            Console.WriteLine();
            Console.WriteLine("PrintFromTimesTwotoDivTwo(4):");
            PrintFromTimesTwotoDivTwo(4);
            Console.WriteLine();
            Console.WriteLine("printFrom1ToNumAndBack(4):");
            printFrom1ToNumAndBack(4);
            Console.WriteLine();
            Console.WriteLine("PrintSums(4):");
            PrintSums(4);
            Console.WriteLine();
            Console.WriteLine("PrintSums2(4):");
            PrintSums2(4);
            Console.WriteLine();
            Console.WriteLine("FactorialOfFactorial(6):");
            FactorialOfFactorial(6);
            Console.WriteLine();
        }
    }
}
