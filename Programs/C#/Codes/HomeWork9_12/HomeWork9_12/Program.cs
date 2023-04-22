using System;

namespace HomeWork9_12
{
    class Program
    {
        static void Main(string[] args)//Page 136 Question 44
        {
            double MinPositive = 0, MaxNegative = -1;
            double num1;
            Console.WriteLine("Enter a number");
            num1 = double.Parse(Console.ReadLine());
            if (num1 > 0)
            {
                MinPositive = num1;
            }
            if (num1 < 0)
            {
                MaxNegative = num1;
            }
            for (int i = 2; i <= 10; i++)
            {
                double num;
                Console.WriteLine("Enter a number");
                num = double.Parse(Console.ReadLine());
                if (num > 0 && MinPositive > num)
                {
                    MinPositive = num;
                }
                if (num < 0 && (Math.Abs(num)) < MaxNegative)
                {
                    MaxNegative = num;
                }
              
            }
            Console.WriteLine($"The smallest positive numebr is {MinPositive}");
            Console.WriteLine($"The biggest negative numbers is {MaxNegative}");
        }
    }
}
