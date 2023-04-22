using System;

namespace Question_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int j=0;
            for (int i = 1; i <= 8; i++)
            {
                int Number;
                Console.WriteLine("Enter a number");
                Number = int.Parse(Console.ReadLine());
                if (Number % 2 == 0)
                {
                    j++;
                }
            }
            Console.WriteLine($"The amount of even numbers is {j}");
        }
    }
}
