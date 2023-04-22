using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (i * j < 10)
                    {
                        Console.Write($"|{i * j} | ");
                    }
                    else
                    {
                        Console.Write($"|{i * j}| ");
                    }
                }
                Console.WriteLine("   ");
            }
        }
    }
}
