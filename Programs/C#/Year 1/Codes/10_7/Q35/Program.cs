using System;

namespace Q35
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 10, Num2 = 10;
            while (Num1 >= 10 && Num1 <= 99 && Num2 >= 10 && Num2 <= 99)
            {
                Console.WriteLine("Enter a pair of two digit number");
                Num1 = int.Parse(Console.ReadLine());
                Num2 = int.Parse(Console.ReadLine());
                int Tens1, Units1, Tens2, Units2;
                Tens1 = Num1 / 10;
                Units1 = Num1 % 10;
                Tens2 = Num2 / 10;
                Units2 = Num2 % 10;
                if (Num1 >= 10 && Num1 <= 99 && Num2 >= 10 && Num2 <= 99)
                {
                    if (Tens1 == Tens2 && Units1 == Units2 || Tens1 == Units2 && Tens2 == Units1)
                    {
                        Console.WriteLine("Common number");
                    }
                    else
                    {
                        Console.WriteLine("Not a common number");
                    }
                }
                
            }
        }
    }
}
