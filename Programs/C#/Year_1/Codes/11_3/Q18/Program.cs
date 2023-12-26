using System;

namespace Q18
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num, BackNum;
            int Count = 1, MaxCount = 0;
            Console.WriteLine("Enter a series of numbers");
            Num = int.Parse(Console.ReadLine());
            BackNum = Num;
            while (Num < 10 && Num >= 0 && Num != -1)
            {
                if (BackNum+1 == Num || BackNum == 9 && Num == 0)
                {
                    Count++;
                }
                else
                {
                    Count = 1;
                }
                if (Count > MaxCount)
                {
                    MaxCount = Count;
                }
                BackNum = Num;
                Num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(MaxCount);
        }
    }
}
