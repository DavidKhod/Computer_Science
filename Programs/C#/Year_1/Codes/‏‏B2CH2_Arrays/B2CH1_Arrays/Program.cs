using System;

namespace B2CH2_Arrays
{
    class SelfExercise1
    {
        public static void Main(String[] args)
        {

            // הגדר מערך באורך 8  של מספרים שלמים
            int[] arr = new int[8];

            // קלוט לכל התאים ערכים מהמשתמש
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter a for an index");
                arr[i] = int.Parse(Console.ReadLine());
            }

            // הדפס את תוכן תאי המערך
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("");
            // הדפס את סכום איברי המערך
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"the sum is {sum}");

            // הדפס את ערכו של האיבר הגדול ביותר במערך
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"The biggest number is {max}");

            // בדוק אם כל ערכי המערך זוגיים והדפס הודעה מתאימה
            int even = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even++;
                }
                
            }
            if (even == arr.Length)
            {
                Console.WriteLine($"all of the numbers are even");
            }
            else
            {
                Console.WriteLine($"not all of the numbers are even");
            }

            // בדוק אם הערכים במערך מסודרים בדר עולה 
            bool isBigger = true;
            int backNum = arr[0];
            for (int i = 1; i < arr.Length && isBigger; i++)
            {
                if (!(arr[i] > backNum))
                    isBigger = false;
                backNum = arr[i];
            }
            if (isBigger)
            {
                Console.WriteLine($"The numbers are in a rising order");
            }
            else
            {
                Console.WriteLine($"The numbers are not in a rising order");
            }

            // הכנס לכל תא את ערך המציין (אינדקס) שלו והדפס את המערך  
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
