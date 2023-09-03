using System;
using Games.DieLib;

namespace EX5
{
    class Program
    {
        static void Main(string[] args)
        {
            Die die = new Die("jump up");

            for (int i = 1; i <= 10; i = i + 2)
            {
                die.Roll();
                Console.WriteLine(i);
            }
        }
    }
}
