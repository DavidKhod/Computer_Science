using System;

namespace _11_1
{
    class Program
    {
        static void Main(string[] args)//Question 3
        {
            int Num1, Num2, Smaller, Bigger;
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Enter a number");
                Num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                Num2 = int.Parse(Console.ReadLine());
                Smaller = Math.Min(Num1, Num2);
                Bigger = Math.Max(Num1, Num2);
                Console.WriteLine("----");
                for (int j = Smaller; j <= Bigger; j++)
                {
                    Console.WriteLine(j);
                }
                Console.WriteLine("/----/");
                while (Smaller <= Bigger)
                {
                    Console.WriteLine(Smaller);
                    Smaller++;
                }
                Console.WriteLine("----");
            }
        }
    }
}
