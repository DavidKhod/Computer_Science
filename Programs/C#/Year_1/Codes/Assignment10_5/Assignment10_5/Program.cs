using System;

namespace Assignment10_5
{
    class Program
    {
        static void Main(string[] args)//Q 17
        {
            int num = 10;
            while (!(num / 10 + num % 10 == 7 && num % 10 + 3 == num/10))
            {
                Console.WriteLine(num);
                num++;
            }
            Console.WriteLine($"The number you were looking for is {num}");
        }
    }
}
