using System;
using Games.DieLib;

namespace EX2_CountDown
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Die die = new Die("Count down");

            Console.Write("Enter a number between 1 - 10: ");
            num = int.Parse(Console.ReadLine());

            for (int i = num; i >= 1; i--)
            {
                die.Roll();
                Console.WriteLine(i);
            }
        }
    }
}

