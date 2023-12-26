using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWP106Q8_9_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int TripleNum, FirstDigit, SecondDigit, ThirdDigit;
            double TriangleNum;
            Console.WriteLine("Enter a three digit number");
            TripleNum = int.Parse(Console.ReadLine());
            FirstDigit = TripleNum / 100;
            SecondDigit = (TripleNum / 10) % 10;
            ThirdDigit = TripleNum % 10;
            TriangleNum = Math.Pow(FirstDigit, 3) + Math.Pow(SecondDigit ,3) + Math.Pow(ThirdDigit, 3);
            if (TriangleNum==TripleNum)
            {
                Console.WriteLine(FirstDigit+"^3 + "+SecondDigit+"^3 + "+ThirdDigit+"^3 = "+TripleNum);
                Console.WriteLine("The number is a triangle number");
            }
            else
            {
                Console.WriteLine(FirstDigit + "^3 + " + SecondDigit + "^3 + " + ThirdDigit + "^3 != " + TripleNum);
                Console.WriteLine("The number is not a triangle number");
            }
        }
    }
}
