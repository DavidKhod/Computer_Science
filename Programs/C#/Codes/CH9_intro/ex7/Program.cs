using Games.DieLib;
using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Die die = new Die("multiple loop variables");

            for (int i = 1, j = 2; i <= 5 && j <= 6; i++, j += 2)
            {
                die.Roll();
                Console.WriteLine("i=" + i + " j=" + j);
            }
        }
    }
}
