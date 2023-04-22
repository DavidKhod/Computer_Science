using Games.DieLib;
using System;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            Die die = new Die("Count up");

            for (int i = 0; i < 10; i++)
            {
                die.Roll();
                Console.WriteLine(i);
            }
        }
    }
}
