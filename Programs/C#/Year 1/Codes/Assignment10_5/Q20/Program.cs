using System;

namespace Q20
{
    class Program
    {
        static void Main(string[] args)
        {
            int SumArea = 0, RugAmount = 0;
            while (!(SumArea >= 200))
            {
                int Length, Width, Area;
                Console.WriteLine("Enter the length of the rug");
                Length = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the width of the rug");
                Width = int.Parse(Console.ReadLine());
                Area = Width * Length;
                SumArea += Area;
                RugAmount++;
            }
            Console.WriteLine($"The amount of rugs guy bought {RugAmount}");
            Console.WriteLine($"The price is {RugAmount * 30}");
        }
    }
}
