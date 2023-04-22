using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q34
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num, Digit,FirstNum;
            bool Yes = false;
            Console.WriteLine("Enter a number");
            Num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a digit");
            FirstNum = Num;
            Digit = int.Parse(Console.ReadLine());
            if (Num % 10 == Digit)
            {
                Yes = true;
            }
            while (Num != 0 && Yes == false)
            {
                Num = Num / 10;
                if (Num % 10 == Digit)
                {
                    Yes = true;
                }
            }
            if (Yes)
            {
                Console.WriteLine("The digit was in the number");
            }
            else
            {
                FirstNum = (FirstNum * 10) + Digit;
                Console.WriteLine($"The number is {FirstNum}");
            }
        }
    }
}
