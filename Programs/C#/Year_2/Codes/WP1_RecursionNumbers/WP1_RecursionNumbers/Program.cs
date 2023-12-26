using System;

namespace WP1_RecursionNumbers
{
    class Program
    {
        // 1.
        // כתןב פעולה שמקבלת מספר שלם חיובי ומחזירה את מספר ספרותיו
        static int CountLength(int num)
        {
            if (num / 10 == 0)//if its a one digit number
                return 1;
            //if the number has two digits, meaning x>=10 
            return CountLength(num / 10) + 1;
        }


        // 2.
        // כתוב פעולה שמקבלת מספר שלם חיובי ומחזירה את סכום הספרות במספר
        static int SumOfDigits(int num)
        {
            if (num / 10 == 0)
                return num;
            else
                return SumOfDigits(num / 10) + num % 10;
        }


        // 3.
        // כתוב פעולה המקבלת מספר שלם חיובי ומחזירה את מספר הספרות הזוגיות במספר
        static int CountEvenDigits(int num)
        {
            if (num / 10 == 0)
            {
                if (num % 2 == 0)//if the number is even return 1 else return 0
                    return 1;
                else
                    return 0;
            }
            else
            {
                int temp = 0;
                if (num % 2 == 0)//Check if the current number is even or odd
                    temp = 1;
                return CountEvenDigits(num / 10) + temp;
            }
        }


        // 4. 
        // כתוב פעולה המקבלת מספר שלם ומחזירה אמת אם הספרה 5 מופיעה במספר
        static bool FindFive(int num)
        {
            if (num / 10 == 0)
            {
                if (num == 5)
                    return true;
                return false;
            }
            else
            {
                if (num % 10 == 5)
                {
                    return true;
                }
                return FindFive(num / 10);
            }
        }


        // 5.
        // כתוב פעולה המקבלת מספר שלם חיובי ומחזירה אמת אם קיימת במספר ספרה
        // המתחלקת ב-3 ללא שארית
        static bool DigitDivisableBy3(int num)
        {
            if (num / 10 == 0)
            {
                if (num % 3 == 0)
                    return true;
                return false;
            }
            else
            {
                if ((num % 10) % 3 == 0)
                    return true;
                return DigitDivisableBy3(num / 10);
            }
        }


        // 6.
        // כתוב פעולה המקבלת מספר שלם ומחזירה אמת אם כל ספרותיו זוגיות
        static bool IsAllDigitEven(int num)
        {
            if (num / 10 == 0)
            {
                if (num % 2 == 0)
                    return true;
                return false;
            }
            else
            {
                if ((num % 10) % 2 != 0)
                    return false;
                return IsAllDigitEven(num / 10);

            }
        }


        // 7.
        // כתוב פעולה המקבלת מספר שלם חיובי 
        // ומחזירה אמת אם כל ספרותיו מסודרות בסדר עולה משמאל לימין
        static bool IsInRaisingOrderFromLeftToRight(int num)
        {
            if (num / 10 == 0)
            {
                return true;
            }
            else
            {
                if (num % 10 < (num / 10) % 10)
                    return false;
                return IsInRaisingOrderFromLeftToRight(num / 10);
            }
        }


        // 8.
        // כתוב פעולה המקבלת מספר שלם חיובי ומחזירה את הספרה הקטנה ביותר במספר
        static int SmallestNum(int num)
        {
            if (num < 100 && num > 10)
            {
                return Math.Min(num % 10, num / 10);
            }
            else
            {
                return Math.Min(SmallestNum(num / 10), num % 10);
            }
        }



        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"The length of the number is: {CountLength(num)}");
            Console.WriteLine($"The amount of even numbers is: {CountEvenDigits(num)}");
            Console.WriteLine($"The sum of all digits is: {SumOfDigits(num)}");

            bool fiveIsFound = FindFive(num);
            if (fiveIsFound)
                Console.WriteLine($"The number has the digit 5 within it");
            else
                Console.WriteLine($"The number doesn't have the digit 5 within it");

            bool divisableBy3 = DigitDivisableBy3(num);
            if (divisableBy3)
                Console.WriteLine($"The number has a digit that is divisable by 3 within it");
            else
                Console.WriteLine($"The number doesn't have a digit that is divisable by 3 within it");

            bool allDigitsEven = IsAllDigitEven(num);
            if (allDigitsEven)
                Console.WriteLine("All of the number's digits are even");
            else
                Console.WriteLine("Not all of the number's digits are even");

            bool isRaisingOrder = IsInRaisingOrderFromLeftToRight(num);
            if (isRaisingOrder)
            {
                Console.WriteLine("Raising order from left to right");
            }
            else
            {
                Console.WriteLine("Not raising order from left to right");
            }

            Console.WriteLine($"The smallest digit is: {SmallestNum(num)}");
        }
    }
}
