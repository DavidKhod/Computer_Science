using System;

namespace Q14
{
    class Program
    {
        static void Main(string[] args)
        {
            double Num;
            for (int i = 1; i <= 1000; i++)
            {
                int j = 2;
                Num = 0;
                while (i / j != 0)
                {
                    Num += i / j;
                    j++;
                }
                if (Num == i)
                {
                    Console.WriteLine($"{i} is a perfect number");
                }
            }

        }
    }
}
