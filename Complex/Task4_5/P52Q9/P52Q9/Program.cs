using System;

namespace P52Q9
{
    class Program
    {
        static Random rnd = new Random();
        /// <summary>
        /// Creates an int Array from the field inputed by the user
        /// </summary>
        /// <param name="length">The length of the Array</param>
        /// <param name="from">The smallest value of the field</param>
        /// <param name="until">The largest value of field</param>
        /// <returns>An int Array</returns>
        static int[] CreateRndArray(int length, int from, int until)
        {
            int[] arr = new int[length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(from, until + 1);
            }
            return arr;
        }

        static void BubbleSort(int[] arr)
        {
            int tempnum;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        tempnum = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tempnum;
                    }
                }
            }
        }

        static void PrintAllMatchingNums(int[] arr1, int[] arr2)
        {
            int i = 0, j = 0;
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] == arr2[j])
                {
                    i++;
                    j++;
                    Console.WriteLine(arr1[i]);
                }
                if (arr1[i] > arr2[j])
                    j++;
                if (arr1[i] < arr2[j])
                    i++;
            }
        }
        static void Main(string[] args)
        {
            int[] arr1 = CreateRndArray(10, 1, 20);
            BubbleSort(arr1);
            int[] arr2 = CreateRndArray(10, 1, 20);
            BubbleSort(arr2);
        }
    }
}
