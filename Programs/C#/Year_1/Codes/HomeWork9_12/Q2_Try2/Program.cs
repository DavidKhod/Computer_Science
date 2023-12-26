using System;

namespace Q2_Try2
{
    class Program
    {
        static void Main(string[] args)
        {
            double min_pos = 0, max_neg = 0;
            for (int i = 1; i <= 10; i++)
            {
                double num;
                Console.WriteLine($"Enter a number");
                num = double.Parse(Console.ReadLine());
                if (min_pos == 0)
                {
                    if (num > min_pos)
                    {
                        min_pos = num;
                    }
                }
                if (max_neg == 0)
                {
                    if (num < max_neg)
                    {
                        max_neg = num;
                    }
                }
                if (max_neg < num && num < 0)
                {
                    max_neg = num;
                }
                if (min_pos > num && num > 0)
                {
                    min_pos = num;
                }
            }
            Console.WriteLine($"The minimum positive number is {min_pos}");
            Console.WriteLine($"The maximum negative numbers is {max_neg}");
        }
    }
}
