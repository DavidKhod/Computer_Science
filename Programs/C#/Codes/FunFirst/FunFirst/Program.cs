using System;

namespace FunFirst
{
    class Program
    {
        static int CountDigit(int Num)
        {
            int Count = 0;
            while (Num != 0)
            {
                Count++;
                Num /= 10;
            }
            return Count;
        }
        static int LongestNum(int num1, int num2, int num3)
        {
            int Longest;
            Longest = Math.Max(CountDigit(num1), Math.Max(CountDigit(num2), CountDigit(num3)));
            if (Longest == CountDigit(num1))
            {
                Longest = num1;
            }
            else if (Longest == CountDigit(num2))
            {
                Longest = num2;
            }
            else if (Longest == CountDigit(num3))
            {
                Longest = num3;
            }
            return Longest;
        }


        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter three numbers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The longest number is {LongestNum(num1, num2, num3)}");
        }
    }
}
