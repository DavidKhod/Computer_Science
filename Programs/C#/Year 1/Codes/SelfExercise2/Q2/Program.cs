using System;

namespace Q2
{
    class Program
    {
        /*
         * ומדפיסה את ערכיהם num2-ו num1 כתוב תוכנית הקולטת שני מספרים שלמים למשתנים 
         * התכנית תחליף בין הערכים של שני המשתנים ותדפיס את הערכים המעודכנים 
         * ולהיפך num2 יהיה ערכו החדש של המשתנה num1-לאחר ההחלפה, הערך שהיה ב
         * num1 יהיה ערכו החדש של המשתנה num2-הערך שהיה ב
         * :לדוגמה: עבור הקלט (משמאל לימין) 4,9 יודפס הפלט הבא
         * num1=4 num2=9
         * num1=9 num2=4
         */

        static void Main(string[] args)
        {
            int num1, num2,num3;
            Console.WriteLine("Enter the first number ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            num2 = int.Parse(Console.ReadLine());
            num3 = num1;
            num1 = num2;
            num2 = num3;
            Console.WriteLine("The first number is "+num1);
            Console.WriteLine("The second number is "+num2);

        }
    }
}
