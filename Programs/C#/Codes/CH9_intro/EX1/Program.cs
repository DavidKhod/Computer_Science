using System;
using Games.DieLib;


namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Die die = new Die("Count 5");

            for (int i = 1; i <= 5; i++)
            {
                die.Roll();
                Console.WriteLine(i);
            }
        }
    }
}
