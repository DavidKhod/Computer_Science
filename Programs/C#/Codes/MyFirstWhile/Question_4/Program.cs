using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, DiffMax = 0, Diff,MaxNum1,MaxNum2;
            Console.WriteLine("Enter a pair of numbers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            Diff = Math.Abs(num1 - num2);
            MaxNum1 = num1;
            MaxNum2 = num2;
            while (!(num1 == 0 && num2 == 0))
            {
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                Diff = Math.Abs(num1 - num2);
                if (Diff > DiffMax)
                {
                    DiffMax = Diff;
                    MaxNum1 = num1;
                    MaxNum2 = num2;
                }
            }
            Console.WriteLine($"The biggest difference is {DiffMax} and its between {MaxNum1} and {MaxNum2}");
        }
    }
}
