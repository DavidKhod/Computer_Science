using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page137_Q45
{
    class Program
    {
        static void Main(string[] args)
        {
            int Min;
            int CoupleMin=1;
            int Firstnum1, Firstnum2;
            Console.WriteLine("Enter a pair of numbers");
            Firstnum1 = int.Parse(Console.ReadLine());
            Firstnum2 = int.Parse(Console.ReadLine());
            Min = Math.Max(Firstnum1, Firstnum2);
            for (int i = 2; i <= 100; i++)
            {
                int num1, num2,Bigger;
                Console.WriteLine("Enter a pair of numbers");
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                Bigger = Math.Max(num1,num2);
                if (Bigger < Min)
                {
                    Min = Bigger;
                    CoupleMin = i;
                }
            }
            Console.WriteLine($"The smallest number of the biggest number in pair {CoupleMin} is {Min}");
        }
    }
}
