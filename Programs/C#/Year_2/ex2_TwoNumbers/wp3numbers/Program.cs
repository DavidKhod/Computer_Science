using System;

namespace wp3numbers
{
    class Program
    {

        // טענת כניסה: הפעולה מקבלת שני מספרים שלמים חיוביים
        // טענת יציאה: הפעולה מחזירה את הפרש אורכי המספרים
        // אפס - יציין אורכים שווים
        // מספר חיובי  - יציין שהמספר הראשון ארוך מהשני
        // מספר שלילי - יציין שהמספר השני ארוך מהראשון
        // -2 הפעולה תחזיר ComareLength(661,25601) לדוגמה: עבור הזימון  
        // כיון שהמספר השני ארוך ב-2 ספרות מהמספר הראשון
        static int CompareLength(int num1, int num2)
        {
            if (num1 == 0 && num2 == 0)
            {
                return 0;
            }
            else
            {
                if (num1 == 0)
                {
                    return CompareLength(num1, num2 / 10) - 1;
                }
                return CompareLength(num1 / 10, num2) + 1;
            }
        }


        // תרגיל 18 עמ 105 בספר האוניברסיטה
        // טענת כניסה: הפעולה מקבלת שני מספרים שלמים חיוביים 
        // טענת יציאה: הפעולה מחזירה את מספר הספרות הזהות בערכן ובמיקומן בשני המספרים
        // ( לדוגמה: עבור המספרים 2661 ו-45601 התשובה היא 2 (ספרת האחדות 1 וספרת המאות 6
        static int CountSimilar(int num1, int num2)
        {
            if (num1 / 10 == 0 || num2 / 10 == 0)
            {
                if (num1 == num2)
                    return 1;
                return 0;
            }
            else
            {
                if (num1 % 10 == num2 % 10)
                {
                    return CountSimilar(num1 / 10, num2 / 10) + 1;
                }
                return CountSimilar(num1 / 10, num2 / 10);
            }
        }

        // טענת כניסה: הפעולה מקבלת שני מספרים שלמים חיוביים
        // טענת יציאה: הפעולה מחזירה את המחלק המשותף הקטן ביותר של שני המספרים
        // לדוגמה: עבור המספרים 30 ו-45 התשובה היא 3
        // הערה: ניתן להשתמש בפעולת עזר רקורסיבית
        static int MinDivisor(int num1, int num2,int minDivadorVariable = 2)
        {
            if (minDivadorVariable > Math.Min(num1,num2))
            {
                return 0;
            }
            if (num1 % minDivadorVariable == 0 && num2 % minDivadorVariable == 0)
            {
                return minDivadorVariable;
            }
            return MinDivisor(num1, num2, minDivadorVariable + 1);
        }


        //לא הצלחתי
        //// טענת כניסה: הפעולה מקבלת שני מספרים שלמים חיוביים
        //// טענת יציאה: הפעולה מחזירה את המחלק המשותף הגדול ביותר של שני המספרים
        //// לדוגמה: עבור המספרים 36 ו-24 התשוה היא 12
        //// הערה: ניתן להשתמש בפעולת עזר רקורסיבית
        //static int MaxDivisor(int num1, int num2, int maxDivadorVariable = 0)
        //{

        //}
        static void Main(string[] args)
        {
            // כתוב תכנית בדיקה
            Console.WriteLine(CompareLength(661, 25601));
            Console.WriteLine(CountSimilar(10, 1000));
            Console.WriteLine(MinDivisor(30,45));
        }
    }
}
