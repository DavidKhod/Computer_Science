using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NB1CH7_st2DigNum
{
    class Program
    {
        static void Main(string[] args)
        {
            /** קלוט  מספר דו-סיפרתי. חשב והדפס את ספרת היחידות וספרת העשרות של המספר */
            int num, digit1, Digit2,OppisitNum;
            Console.WriteLine("Enter a two digit number");
            num = int.Parse(Console.ReadLine());
            digit1 = num / 10;
            Digit2 = num % 10;
            Console.WriteLine("The dozens digit is " + digit1);
            Console.WriteLine("The first digit is " + Digit2);
            /**חשב את סכום הספרות של המספר */
            Console.WriteLine("The sum of the numbers is " + (digit1 + Digit2));

            /** הדפס את ספרות המספר בסדר הפוך (עם רווח ביניהם) */
            Console.WriteLine("The numbers are " + Digit2 + " " + digit1);

            /** השם לתוך משתנה אחר את המספר שספרותיו בסדר הפוך למספר שקלטת והדפס את תוכנו */
            OppisitNum = (Digit2*10)+digit1;
            Console.WriteLine("The Replacment number is "+OppisitNum);



           



        }
    }
}
