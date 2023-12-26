using System;

namespace MyFirstWhile
{
    class Program
    {
        static void Main(string[] args)//Question 1
        {
            int Num,sum=0,count=0;
            double avg;
            Console.WriteLine("Enter the two digit number");
            Num = int.Parse(Console.ReadLine());
            while (Num >= 10 && Num < 100)
            {
                count++;
                sum += Num;
                Console.WriteLine("Enter another two digit number");
                Num = int.Parse(Console.ReadLine());
            }
            avg = sum / count;
            Console.WriteLine($"The average number is {avg}");
        }
    }
}
