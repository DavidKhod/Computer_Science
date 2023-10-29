using System;

namespace Task3_8C
{
    class Program
    {
        static void FromNTo1(int n)
        {
            if (n != 0)
            {
                Console.Write($"{n} ");
                FromNTo1(n - 1);
            }
        }

        static void From1ToN(int n)
        {
            if (n != 0)
            {
                From1ToN(n - 1);
                Console.Write($"{n} ");
            }
        }
        static void Main(string[] args)
        {
            FromNTo1(4);
            Console.WriteLine();
            From1ToN(4);
            Console.WriteLine();
        }
    }
}
