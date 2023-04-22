using System;
namespace Q15
{
    class Program
    {
        static void Main(string[] args)
        {
            int Count = 0;
            bool CanBeDiv = false;
            int j = 2;
            for (int i = 1; i <= 30; i++)
            {
                CanBeDiv = false;
                if (i / 1 == 0 && i / i == 0 && i / 2 != 0)
                {
                    Count++;
                }
            }
            Console.WriteLine(Count);
        }
    }
}
