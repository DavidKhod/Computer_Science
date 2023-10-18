using System;
namespace Task3_5
{
    class Program
    {
        //Q1
        static int CountPosNums(int[] arr)
        {
            return CountPosNums(arr, 0);
        }

        static int CountPosNums(int[] arr, int i)
        {
            if (i == arr.Length - 1)
            {
                if (arr[i] > 0)
                    return 1;
                return 0;
            }
            if (arr[i] > 0)
                return CountPosNums(arr, i + 1) + 1;
            return CountPosNums(arr, i + 1);
        }

        //Q2
        static int WhichPlace(int[] arr, int num)
        {
            return WhichPlace(arr, 0, num);
        }

        static int WhichPlace(int[] arr, int i, int num)
        {
            if (i == arr.Length - 1)
            {
                if (arr[i] == num)
                    return 0;
                return -arr.Length;
            }
            if (arr[i] == num)
                return 0;
            return WhichPlace(arr, i + 1, num) + 1;
        }

        //Q3
        static bool IsRaisingOrder(int[] arr)
        {
            return IsRaisingOrder(arr, 0);
        }

        static bool IsRaisingOrder(int[] arr, int i)
        {
            if (i + 1 == arr.Length - 1)
            {
                if (arr[i] < arr[i + 1])
                    return true;
                return false;
            }
            if (arr[i] > arr[i + 1])
                return false;
            return IsRaisingOrder(arr, i + 1);
        }

        //Q4
        static int CountNumberBiggerThanNeigbor(int[] arr)
        {
            return CountNumberBiggerThanNeigbor(arr, 1);
        }

        static int CountNumberBiggerThanNeigbor(int[] arr, int i)
        {
            if (i + 1 == arr.Length - 1)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                    return 1;
                return 0;
            }
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                return CountNumberBiggerThanNeigbor(arr, i + 1) + 1;
            return CountNumberBiggerThanNeigbor(arr, i + 1);
        }

        //Q5
        static int sumOfEvenAndOddDigits(int[] arr)
        {
            return sumOfEvenAndOddDigits(arr, 0);
        }

        static int sumOfEvenAndOddDigits(int[] arr, int i)
        {
            if (i == arr.Length - 1 || i + 1 == arr.Length - 1)
            {
                if ((arr.Length - 1) % 2 != 0)
                    return -arr[i + 1];
                return 0;
            }
            return sumOfEvenAndOddDigits(arr, i + 2) + arr[i] - arr[i + 1];
        }

        //Q6
        static bool OppositeArrays(int[] arr1, int[] arr2)
        {
            return OppositeArrays(arr1, arr2, 0);
        }

        static bool OppositeArrays(int[] arr1, int[] arr2, int i)
        {
            if (i == arr1.Length - 1)
            {
                if (arr1[i] == arr2[arr2.Length - 1 - i])
                    return true;
                return false;
            }
            if (arr1[i] != arr2[arr2.Length - 1 - i])
                return false;
            return OppositeArrays(arr1, arr2, i + 1);
        }

        //Q7
        static bool IsArrayPolinom(int[] arr)
        {
            return IsArrayPolinom(arr, 0);
        }

        static bool IsArrayPolinom(int[] arr, int i)
        {
            if (i == (arr.Length - 1) / 2)
            {
                if (arr[i] == arr[arr.Length - 1 - i])
                    return true;
                return false;
            }
            if (arr[i] == arr[arr.Length - 1 - i])
                return IsArrayPolinom(arr, i + 1);
            return false;
        }

        //Q8
        static bool IsItInvoiceSeries(int[] arr)
        {
            return IsItInvoiceSeries(arr, 1);
        }

        static bool IsItInvoiceSeries(int[] arr, int i)
        {
            if (i + 1 == arr.Length - 1)
            {
                if (Math.Abs(arr[i] - arr[i + 1]) == Math.Abs(arr[0] - arr[1]))
                    return true;
                return false;
            }
            if (Math.Abs(arr[i] - arr[i + 1]) == Math.Abs(arr[0] - arr[1]))
                return IsItInvoiceSeries(arr, i + 1);
            return false;
        }

        //Q9

        static bool IsPrimeNumber(int num, int div = 2)
        {
            if (div == num / 2)
                return true;
            if (num % div == 0)
                return false;
            return IsPrimeNumber(div + 1);
        }

        static bool IsPrimeInIt(int[] arr)
        {
            return IsPrimeInIt(arr, 0);
        }

        static bool IsPrimeInIt(int[] arr, int i)
        {
            if (i == arr.Length - 1)
            {
                if (IsPrimeNumber(arr[i]))
                    return true;
                return false;
            }
            if (IsPrimeNumber(arr[i]))
                return true;
            return IsPrimeInIt(arr, i + 1);
        }

        //Q10
        static bool IsBalancedDigit(int[] arr)
        {
            if (arr.Length % 2 == 0)
                return false;
            return IsBalancedDigit(arr, 0);
        }


        static bool IsBalancedDigit(int[] arr, int i)
        {
            int mid = arr.Length / 2;
            if (i == arr.Length / 2)
            {
                if (arr[mid - i] > 0 && arr[mid + i] < 0)
                    return true;
                return false;
            }
            if (arr[mid - i] > 0 && arr[mid + i] < 0)
                return IsBalancedDigit(arr, i + 1);
            return false;
        }

        //My Functions
        /// <summary>
        /// Prints the array inputed
        /// </summary>
        /// <param name="arr">The array inputed</param>
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"|{arr[i]}| ");
            }
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            //Q2
            int[] arr1 = { 1, 2, 3, 4, 5 };
            PrintArray(arr1);
            Console.WriteLine($"3 in arr1 is in place: {WhichPlace(arr1, 3)}");
            //Q3
            PrintArray(arr1);
            Console.WriteLine($"arr1 is raising order: {IsRaisingOrder(arr1)}");
            //Q4
            int[] arr2 = { 1, 6, 2, 7, 1, 3, 5, 9 };
            int[] arr3 = { 1, 7, 2, 8, 4, 9, 5, 4 };
            PrintArray(arr2);
            Console.WriteLine($"Bigger then their neighbors amount in arr2 is: {CountNumberBiggerThanNeigbor(arr2)}");
            PrintArray(arr3);
            Console.WriteLine($"Bigger then their neighbors amount in arr3 is: {CountNumberBiggerThanNeigbor(arr3)}");
            //Q5
            int[] arr4 = { 1, 2, 3, 4, 5, -1, -2, -3, -4, -5 };
            int[] arr5 = { 1, -5, 1, -6, 3, 1, -9, 1 };
            PrintArray(arr4);
            Console.WriteLine($"The sum of even minus odd numbers in arr4 is: {sumOfEvenAndOddDigits(arr4)}");
            PrintArray(arr5);
            Console.WriteLine($"The sum of even minus odd numbers in arr5 is: {sumOfEvenAndOddDigits(arr5)}");
            //Q6
            int[] arr6 = { 5, 4, 3, 2, 1 };
            int[] arr7 = { 1, 2, 3, 1, 5 };
            PrintArray(arr1);
            PrintArray(arr6);
            Console.WriteLine($"Are arr1 and arr6 opposites: {OppositeArrays(arr1, arr6)}");
            PrintArray(arr7);
            PrintArray(arr6);
            Console.WriteLine($"Are arr7 and arr6 opposites: {OppositeArrays(arr7, arr6)}");
            //Q7
            int[] arr8 = { 3, 4, 5, 4, 4, 3 };
            int[] arr9 = { 3, 4, 5, 5, 4, 3 };
            PrintArray(arr8);
            Console.WriteLine($"Is arr8 polinom: {IsArrayPolinom(arr8)}");
            PrintArray(arr9);
            Console.WriteLine($"Is arr9 polinom: {IsArrayPolinom(arr9)}");
        }
    }
}
