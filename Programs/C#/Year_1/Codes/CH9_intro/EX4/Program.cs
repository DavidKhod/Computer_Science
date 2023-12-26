using Games.DieLib;
using System;

namespace EX4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Die die = new Die("up or down");

            Console.Write("Enter a number between 1 - 10: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number between 1 - 10: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 < num2)
            {
                for (int i = num1; i <= num2; i++)
                {
                    die.Roll();
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = num1; i >= num2; i--)
                {
                    die.Roll();
                    Console.WriteLine(i);
                }
            }
        }
    }
}
