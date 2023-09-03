using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page132_8_12_22
{
    class Program
    {
        static void Main(string[] args)// Question 32
        {
            int Money,Sum=0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Enter the amount of money you have");
                Money = int.Parse(Console.ReadLine());
                Sum = Sum + Money;
            }
            Console.WriteLine("The amount of money colected is "+Sum);
        }
    }
}
