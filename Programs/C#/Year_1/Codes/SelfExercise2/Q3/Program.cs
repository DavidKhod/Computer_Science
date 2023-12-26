using System;

namespace Q3
{
    class Program
    {
        /*
         * 	כתוב תוכנית שתקלוט את מחירה של חולצה
         * 	ומציג כפלט את מחירה לאחר הנחה בשיעור של 25%
         * 	פלט התוכנית יכלול את הדברים הבאים:
         * 	1. מחיר החולצה המקורי
         * 	2. גובה ההנחה בשקלים חדשים
         * 	3. מחיר החולצה לאחר ההנחה
         */
        static void Main(string[] args)
        {
            double ShirtP, ShirtDis = 0, ShirtNP = 0;
            Console.WriteLine("Enter the price of the shirt");
            ShirtP = double.Parse (Console.ReadLine());
            Console.WriteLine("The price of the shirt was " +ShirtP);
            ShirtDis = ShirtP / 4;
            Console.WriteLine("The discount amout is "+(ShirtDis)+" Shekels");
            ShirtNP = ShirtP - ShirtDis;
            Console.WriteLine("The new price of the shirt with the discount is " + ShirtNP);
        }
    }
}
