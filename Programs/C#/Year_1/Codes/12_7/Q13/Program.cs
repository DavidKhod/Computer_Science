using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13
{
    class Program
    {
        static int SmallestNum (int Num)
        {
            int Digit, Tens, Huns, Smallest;
            Digit = Num % 10;
            Tens = Num % 100 / 10;
            Huns = Num / 100;
            Smallest = Math.Min(Math.Min(Digit, Tens), Huns);
            return Smallest;
        }
        static void Main(string[] args)
        {
            int Num;
            Console.WriteLine("Enter a three digit number");
            Num = int.Parse(Console.ReadLine());
            while (Num > 99 && Num < 1000)
            {
                Console.WriteLine($"The smallest number with in {Num} is {SmallestNum(Num)}");
                Console.WriteLine("Enter a three digit number");
                Num = int.Parse(Console.ReadLine());
            }
        }
    }
}

