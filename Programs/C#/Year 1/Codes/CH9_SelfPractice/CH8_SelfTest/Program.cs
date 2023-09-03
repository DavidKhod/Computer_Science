using System;

namespace CH8_SelfTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // כתוב קטע קוד שידפיס את כל המספרים הדו-סיפרתיים
            Console.WriteLine("\nAll 2-digit numbers in ascending order");
            for (int i = 10; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            // כתוב קטע קוד שידפיס את כל המספרים התלת-ספרתיים בסדר הפוך
            Console.WriteLine("\nAll 3-digit numbers in descending order");
            for (int i = 0; 100 < 1000; i--)
            {
                Console.WriteLine(i);
            }


            // כתוב קטע קוד שידפיס את כל אותיות ה-א"ב הקטנות באנגלית
            Console.WriteLine("\nAll small abc letters");
            for (int i = 97; i <= 122; i++)
            {
                Console.WriteLine((Char)i);
            }

            // כתוב קטע קוד שידפיס את כל המספרים הזוגיים בין 0 ל-50 (כולל)
            Console.WriteLine("\nAll even numbers between 0 and 50");
            for (int i = 0; i <= 50; i = i + 2)
            {
                Console.WriteLine(i);
            }

            // כתוב קטע קוד שידפיס את כל המספרים האי-זוגיים בין 0ל-50 (כולל)
            Console.WriteLine("\nAll odd numbers between 0 and 50");
            for (int i = 1; i < 51; i = i + 2)
            {
                Console.WriteLine(i);
            }

            // קלוט מספר חיובי שלם בין 1 ל-100 והדפס את כל המחלקים של המספר
            int num;
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("\nAll dividers of " + num);
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }


            // הדפס את כל המספרים בין 10 ל-100 שמופיעה בהם הספרה 7
            Console.WriteLine("\nAll numbers between 10 to 100 with digit 7");
            for (int i = 10; i < 101; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }

            // הדפס את כל המספרים הדו-סיפרתיים שמתחלקים ב-3
            Console.WriteLine("\nAll 2-digit numbers that are divided by 3");
            for (int i = 10; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //הדפס את כל המספרים התלת סיפרתיים שסכום ספרותיהם הוא 12
            Console.WriteLine("\nAll 3-digit numbers whose digits' sum = 12");
            for (int i = 100; i < 1000; i++)
            {
                if ((i % 10) + (i / 100) + ((i / 10) % 10) == 12)
                {
                    Console.WriteLine(i);
                }
            }

            //a,c,e,g,i..,y הדפס את את סדרת האותיות הבאה:
            Console.WriteLine("\nAll small abc letters in steps of two ");
            for (int i = 97; i <= 122; i = i + 2)
            {
                Console.WriteLine((Char)i);
            }


        }
    }
}
