using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P146_147
{
    class Program
    {
        static void Main(string[] args)//Question 6
        {
            int Num, MaxNum = 0, Units, Tens;
            Console.WriteLine("Enter a two digit number");
            Num = int.Parse(Console.ReadLine());
            Units = Num % 10;
            Tens = Num / 10 % 10;
            if (Num >= 10 && Num < 100)
            {
                if (Units != Tens)
                {
                    MaxNum = Num;
                }
            }
            while (Num>=10 && Num < 100)
            {
                Console.WriteLine("Enter a two digit number");
                Num = int.Parse(Console.ReadLine());
                Units = Num % 10;
                Tens = Num / 10 % 10;
                if (Units != Tens)
                {
                    if (Num > MaxNum)
                    {
                        MaxNum = Num;
                    }
                }
            }
            Console.WriteLine($"The biggest number with two different digits is {MaxNum}");
        }
    }
}
