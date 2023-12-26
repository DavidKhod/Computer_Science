using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            double MaxNum1, MaxNum2;
            double MaxTimes;
            Console.WriteLine("Enter a pair of whole positive numbers");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            MaxNum1 = num1;
            MaxNum2 = num2;
            MaxTimes = num1 * num2;
            while (num1 % 1 == 0 && num2 % 1 == 0 && num1 > 0 && num2 > 0)
            {
                Console.WriteLine("Enter another pair of whole positive numbers");
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                if (num1 * num2 > MaxTimes)
                {
                    MaxTimes = num1 * num2;
                    MaxNum1 = num1;
                    MaxNum2 = num2;
                }
            }
            Console.WriteLine($"The pair with biggest times is {MaxNum1} and {MaxNum2} and the times is {MaxTimes}");
        }
    }
}
