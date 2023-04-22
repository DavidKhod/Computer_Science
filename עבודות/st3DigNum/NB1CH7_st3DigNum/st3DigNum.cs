using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NB1CH7_st3DigNum
{
    class st3DigNum
    {
        static void Main(string[] args)
        {
            /** קלוט למשתנה num מספר תלת-סיפרתי. חשב והדפס את ספרת היחידות, ספרת העשרות וספרת המאות של המספר */
            int num,Digit, dozens, hundreds,sum1,opposite;
            Console.WriteLine("The a three digit number");
            num = int.Parse(Console.ReadLine());
            hundreds = num / 100;
            dozens = (num / 10)%10;
            Digit = num % 10;
            Console.WriteLine("The hundreds number is "+hundreds);
            Console.WriteLine("The dozens number is "+dozens);
            Console.WriteLine("The Digit number is "+Digit);
            /**חשב את סכום הספרות של המספר */
            sum1 = hundreds + dozens + Digit;
            Console.WriteLine("The sum of the numbers is "+sum1);

            /** הדפס את ספרות המספר בסדר הפוך (עם רווח ביניהם) */
            Console.WriteLine("The oppsite order is "+Digit+" "+dozens+" "+hundreds);

            /** השם לתוך המשתנה opposite את המספר שספרותיו בסדר הפוך ל-num והדפס את תוכנו */
            opposite = Digit*100 + dozens*10+hundreds;
            Console.WriteLine("The opposite number is "+opposite);

        }
    }
}
