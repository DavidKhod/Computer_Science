using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P88_Q47_3_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            bool y1x1, y1x2, y1x3, y2x1, y2x2, y2x3, y3x1, y3x2, y3x3;
            char y1, y2, y3, y4, y5, y6, y7, y8, y9;
            int num1, num2, num3;
            
            Console.WriteLine("Enter the first card chosen");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second card chosen");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Third card chosen");
            num3 = int.Parse(Console.ReadLine());
            y1x1 = ((num1 == 1) || (num2 == 1) || (num3 == 1));
            y1x2 = ((num1 == 2) || (num2 == 2) || (num3 == 2));
            y1x3 = ((num1 == 3) || (num2 == 3) || (num3 == 3));
            y2x1 = ((num1 == 4) || (num2 == 4) || (num3 == 4));
            y2x2 = ((num1 == 5) || (num2 == 5) || (num3 == 5));
            y2x3 = ((num1 == 6) || (num2 == 6) || (num3 == 6));
            y3x1 = ((num1 == 7) || (num2 == 7) || (num3 == 7));
            y3x2 = ((num1 == 8) || (num2 == 8) || (num3 == 8));
            y3x3 = ((num1 == 9) || (num2 == 9) || (num3 == 9));
            if (y1x1)
            {
                Console.WriteLine("Did the kid answer the first question right? if yes 'y' if not 'n'");
                y1 = char.Parse(Console.ReadLine());
            }
            if (y1x2)
            {
                Console.WriteLine("Did the kid answer the second question right? if yes 'y' if not 'n'");
                y2 = char.Parse(Console.ReadLine());
            }
            if (y1x3)
            {
                Console.WriteLine("Did the kid answer the third question right? if yes 'y' if not 'n'");
                y3 = char.Parse(Console.ReadLine());
            }
            if (y2x1)
            {
                Console.WriteLine("Did the kid answer the forth question right? if yes 'y' if not 'n'");
                y4 = char.Parse(Console.ReadLine());
            }
            if (y2x2)
            {
                Console.WriteLine("Did the kid answer the fifth question right? if yes 'y' if not 'n'");
                y5 = char.Parse(Console.ReadLine());
            }
            if (y2x3)
            {
                Console.WriteLine("Did the kid answer the sixth question right? if yes 'y' if not 'n'");
                y6 = char.Parse(Console.ReadLine());
            }
            if (y3x1)
            {
                Console.WriteLine("Did the kid answer the seventh question right? if yes 'y' if not 'n'");
                y7 = char.Parse(Console.ReadLine());
            }
            if (y3x2)
            {
                Console.WriteLine("Did the kid answer the eighth question right? if yes 'y' if not 'n'");
                y8 = char.Parse(Console.ReadLine());
            }
            if (y3x3)
            {
                Console.WriteLine("Did the kid answer the ninth question right? if yes 'y' if not 'n'");
                y9 = char.Parse(Console.ReadLine());
            }
            if (y1 =='y' && y2 =='y' && y3 =='y')
            {
                Console.WriteLine("The kid gets a present");
            }
        }
    }
}
