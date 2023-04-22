using System;

namespace Q36
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num, BackNum;
            int MaxCount = 0, Count = 1;
            Console.WriteLine("Enter a number");
            Num = int.Parse(Console.ReadLine());
            while (Num != 0)
            {
                BackNum = Num;
                Console.WriteLine("Enter another number");
                Num = int.Parse(Console.ReadLine());
                if (Num > BackNum)
                {
                    Count++;
                }
                if (Count > MaxCount)
                {
                    MaxCount = Count;
                }
                if (!(Num > BackNum))
                {
                    Count = 0;
                }
            }
            Console.WriteLine($"The longest rising series of number is {MaxCount}");
        }
    }
}
