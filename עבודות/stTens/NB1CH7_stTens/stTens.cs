using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NB1CH7_stTens
{
    class stTens
    {
        static void Main(string[] args)
        {
            /** קלוט מספר דו-סיפרתי. חשב והדפס מהי ספרת העשרות של המספר */
            int num1, digit, num2, digit2, num3, digit3, num4, digit4;
            Console.WriteLine("Enter a two digit number");
            num1 = int.Parse(Console.ReadLine());
            digit = num1 / 10;
            Console.WriteLine("The dozens number is " + digit);
            /** קלוט מספר תלת-סיפרתי. חשב והדפס מהי ספרת העשרות של המספר */
            Console.WriteLine("Enter a three digit number");
            num2 = int.Parse(Console.ReadLine());
            digit2 = (num2 / 10) % 10;
            Console.WriteLine("The dozens number is " + digit2);

            /** קלוט מספר חד-סיפרתי. חשב והדפס מהי ספרת העשרות של המספר */
            Console.WriteLine("Enter a two digit number");
            num3 = int.Parse(Console.ReadLine());
            digit3 = num3 / 10;
            Console.WriteLine("The dozens number is " + digit3);

            /** קלוט מספר שלם כלשהו.  שב והדפס מהי ספרת העשרות של המספר */
            Console.WriteLine("Enter a number");
            num4 = int.Parse(Console.ReadLine());
            digit4 = (num4 / 10) % 10;
            Console.WriteLine("The dozens number is " + digit4);

        }
    }
}





















