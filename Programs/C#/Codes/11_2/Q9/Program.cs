using System;
namespace Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        if (i<j)
            //        {
            //            System.Console.WriteLine(i + " " + j);
            //        }
            //    }
            //}
            //1. the answers are 1/2 1/3 1/4 2/3 2/4 3/4
            //2. 16
            int Ey = 1;
            for (int i = 1; i <= n; i++)
            {
                while (i + Ey <= 4)
                {
                    Console.WriteLine($"{i} {i + Ey}");
                    Ey++;
                }
                Ey = 1;
            }
        }
    }
}
