using System;

namespace Q8
{
    class Program
    {
        static int DivisionNumber(int num1, int num2)
        {
            int MaxNum = Math.Max(num1, num2);
            int MinNum = Math.Min(num1, num2);
            int i = 2;
            while (!(MaxNum % i == 0 && MinNum % i == 0) && i <= MaxNum)
            {
                i++;
            }
            if (i == MaxNum + 1)
            {
                i = -1;
            }
            return i;
        }
        static void Main(string[] args)
        {
            int Num1, Num2;
            Console.WriteLine("Enter a pair number");
            Num1 = int.Parse(Console.ReadLine());
            Num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The smallest number that they're both dividable is {DivisionNumber(Num1, Num2)}");
            Console.WriteLine("--------------");
            int Count = 0;
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Enter a pair number");
                Num1 = int.Parse(Console.ReadLine());
                Num2 = int.Parse(Console.ReadLine());
                if (DivisionNumber(Num1, Num2) == -1)
                {
                    Count++;
                }
            }
            Console.WriteLine($"The amount of indivisiable numbers is {Count}");
        }
    }
}
