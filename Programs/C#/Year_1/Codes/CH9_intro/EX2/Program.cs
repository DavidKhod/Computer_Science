using System;
using Games.DieLib;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Die die = new Die("count up");

            Console.Write("Enter a number between 1 - 10: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                die.Roll();
                Console.WriteLine(i);
            }
        }
    }
}
