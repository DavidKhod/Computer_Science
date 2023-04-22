using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NB1CH7_stUnits
{
    class Units
    {
        static void Main(string[] args)
        {
            /** קלוט מספר דו-סיפרתי. חשב והדפס מהי ספרת היחידות של המספר */
            int num, digit,num2,digit2,num3,num4,digit4;
            Console.WriteLine("Enter a two digit number");
            num = int.Parse(Console.ReadLine());
            digit = num % 10;
            Console.WriteLine("The digit number is "+digit);


            /** קלוט מספר תלת-סיפרתי. חשב והדפס מהי ספרת היחידות של המספר */
            Console.WriteLine("Enter a three digit number");
            num2 = int.Parse(Console.ReadLine());
            digit2 = num2 % 10;
            Console.WriteLine("The third digit of "+num2+" is "+digit2);

            /** קלוט מספר חד-סיפרתי. חשב והדפס מהי ספרת היחידות של המספר */
            Console.WriteLine("Enter a one digit number");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("The digit is "+num3);

            /** קלוט מספר שלם כלשהו.  שב והדפס מהי ספרת היחידות של המספר */
            Console.WriteLine("Enter a number");
            num4 = int.Parse(Console.ReadLine());
            digit4 = num4 % 10;
            Console.WriteLine("The digit of "+num4+" is "+digit4);
        }
    }
}
