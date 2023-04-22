using System;

namespace NB1CH6_st2
{
    class DividerOrNot
    {
        /*
         * קלט : שני מספרים שלמים חיוביים
         * פלט: הודעה האם המספר הראשון מתחלק בשני ללא שארית
         * אם המספר מתחלק ללא שארית, הדפס בנוסף את תוצאת החילוק
         * אחרת, הדפס את שארית חילוק השלמים
         */

        static void Main(string[] args)
        {
            /* השלם את הקוד הדרוש */
            int num1, num2;
            Console.WriteLine("Enter a number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            num2 = int.Parse(Console.ReadLine());
            if (num1 % num2 == 0)
            {
                Console.WriteLine("The number can be devided by each other without any leftovers");
            }
            else
            {
                Console.WriteLine("The number cannot be divided without leftovers");
            }

        }
    }
}
