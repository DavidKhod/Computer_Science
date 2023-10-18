using System;
namespace recArray
{
    class Program
    {
        // 1.
        // כתוב פעולה שמקבלת מערך חד ממדי של מספרים שלמים
        // ומחזירה את סכום האיברים במערך
        static int SumOfDigits(int[] arr)
        {
            return SumOfDigits(arr, 0);
        }

        static int SumOfDigits(int[] arr, int i)
        {
            if (i == arr.Length - 1)
            {
                return arr[i];
            }
            return SumOfDigits(arr, i + 1) + arr[i];
        }

        // 2.
        // כתןב פעולה שמקבלת מערך חד ממדי של מספרים שלמים 
        // ומחזירה את מספר האיברים החיוביים במערך
        static int SumOfAllPositive(int[] arr)
        {
            return SumOfAllPositive(arr, 0);
        }
        static int SumOfAllPositive(int[] arr, int i)
        {
            if (i == arr.Length - 1)
            {
                if (arr[i] > 0)
                    return arr[i];
                return 0;
            }
            if (arr[i] > 0)
                return SumOfAllPositive(arr, i + 1) + arr[i];
            return SumOfAllPositive(arr, i + 1);

        }


        // 3.
        // כתןב פעולה שמקבלת מערך חד ממדי של מספרים שלמים 
        // ומחזירה אמת אם יש לפחות איבר שלילי אחד במערך
        static bool IsThereNegative(int[] arr)
        {
            return IsThereNegative(arr, 0);
        }
        static bool IsThereNegative(int[] arr, int i)
        {
            if (i == arr.Length - 1)
            {
                if (arr[i] < 0)
                    return true;
                return false;
            }
            if (arr[i] < 0)
                return true;
            return IsThereNegative(arr, i + 1);
        }


        // 4. 
        // כתןב פעולה שמקבלת מערך חד ממדי של מספרים שלמים 
        // ומחזירה את המספר שערכו הוא המקסימלי מבין כל איברי במערך
        static int MaxNumber(int[] arr)
        {
            return MaxNumber(arr, 0);
        }

        static int MaxNumber(int[] arr, int i)
        {
            if (i == arr.Length - 1)
                return arr[i];
            return Math.Max(MaxNumber(arr, i), arr[i]);
        }


        // 5.
        // כתןב פעולה שמקבלת מערך חד ממדי של מספרים שלמים 
        // ומחזירה אמת אם יש שלושה איברים עוקבים זהים במערך
        static bool IsThereTriple(int[] arr)
        {
            return IsThereTriple(arr, 0);
        }

        static bool IsThereTriple(int[] arr, int i)
        {
            if (i + 2 == arr.Length - 1)
            {
                if (arr[i] == arr[i + 1] && arr[i + 1] == arr[i + 2])
                    return true;
                return false;
            }
            if (arr[i] == arr[i + 1] && arr[i + 1] == arr[i + 2])
                return true;
            return IsThereTriple(arr, i + 1);
        }


        // 6.
        // כתןב פעולה שמקבלת מערך חד ממדי של מספרים שלמים 
        // ומחזירה אמת אם יש שני איברים שכנים בעלי אותה זוגיות במערך
        static bool IsThereTwoEvenOrOddTogether(int[] arr)
        {
            return IsThereTwoEvenOrOddTogether(arr, 0);
        }
        static bool IsThereTwoEvenOrOddTogether(int[] arr, int i)
        {
            if (i + 1 == arr.Length - 1)
            {
                if ((arr[i] % 2 == 0 && arr[i + 1] % 2 == 0) || (arr[i] % 2 != 0 && arr[i + 1] % 2 != 0))
                    return true;
                return false;
            }
            if ((arr[i] % 2 == 0 && arr[i + 1] % 2 == 0) || (arr[i] % 2 != 0 && arr[i + 1] % 2 != 0))
                return true;
            return IsThereTwoEvenOrOddTogether(arr, i + 1);
        }



        static void Main(string[] args)
        {

            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { -1, 2, 3, -4, 5 };
            int[] arr3 = { 1, 1, 1, 2, 2, 3 };
            int[] arr4 = { 1, 2, 2, 2, 3 };
            int[] arr5 = { 1, 2, 3, 4, 5, 5, 5 };

            // 1. Test SumOfDigits
            int sum1 = SumOfDigits(arr1);
            int sum2 = SumOfDigits(arr2);
            Console.WriteLine("Sum of arr1: " + sum1); // Output: Sum of arr1: 15
            Console.WriteLine("Sum of arr2: " + sum2); // Output: Sum of arr2: 5

            // 2. Test SumOfAllPositive
            int positiveSum1 = SumOfAllPositive(arr1);
            int positiveSum2 = SumOfAllPositive(arr2);
            Console.WriteLine("Sum of positive numbers in arr1: " + positiveSum1); // Output: Sum of positive numbers in arr1: 15
            Console.WriteLine("Sum of positive numbers in arr2: " + positiveSum2); // Output: Sum of positive numbers in arr2: 10

            // 3. Test IsThereNegative
            bool hasNegative1 = IsThereNegative(arr1);
            bool hasNegative2 = IsThereNegative(arr2);
            Console.WriteLine("arr1 has a negative number: " + hasNegative1); // Output: arr1 has a negative number: False
            Console.WriteLine("arr2 has a negative number: " + hasNegative2); // Output: arr2 has a negative number: True

            // 4. Test MaxNumber
            int max1 = MaxNumber(arr1);
            int max2 = MaxNumber(arr2);
            Console.WriteLine("Max number in arr1: " + max1); // Output: Max number in arr1: 5
            Console.WriteLine("Max number in arr2: " + max2); // Output: Max number in arr2: 5

            // 5. Test IsThereTriple
            bool hasTriple1 = IsThereTriple(arr3);
            bool hasTriple2 = IsThereTriple(arr4);
            bool hasTriple3 = IsThereTriple(arr5);
            Console.WriteLine("arr3 has a triple: " + hasTriple1); // Output: arr3 has a triple: True
            Console.WriteLine("arr4 has a triple: " + hasTriple2); // Output: arr4 has a triple: True
            Console.WriteLine("arr5 has a triple: " + hasTriple3); // Output: arr5 has a triple: True

            // 6. Test IsThereTwoEvenOrOddTogether
            bool hasTwoEvenOrOddTogether1 = IsThereTwoEvenOrOddTogether(arr1);
            bool hasTwoEvenOrOddTogether2 = IsThereTwoEvenOrOddTogether(arr2);
            Console.WriteLine("arr1 has two even or two odd numbers together: " + hasTwoEvenOrOddTogether1); // Output: arr1 has two even or two odd numbers together: false
            Console.WriteLine("arr2 has two even or two odd numbers together: " + hasTwoEvenOrOddTogether2); // Output: arr2 has two even or two odd numbers together: true
        }
    }
}
