using System;
using Games.DieLib;

namespace EX6_ext_i
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Die die = new Die("variable i scope");

            for (i = 1; i <= 5; i++)
            {
                die.Roll();
                Console.WriteLine(i);
            }

            Console.WriteLine("I am still alive !!!  i=" +i);
        }
    }
}
