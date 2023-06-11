using System;

namespace SelectionSort
{
    class Program
    {
        /// <summary>
        /// Input an unsorted Int Array
        /// </summary>
        /// <param name="arr">The unsorted Int Array</param>
        /// <returns>The Array sorted in a rising order</returns>
        static void SelectionSort(int[] arr)
        {
            int min;
            int indexOfMin;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = arr[i];
                indexOfMin = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (min > arr[j])
                    {
                        min = arr[j];
                        indexOfMin = j;
                    }
                }
                int temp = arr[i];
                arr[i] = min;
                arr[indexOfMin] = temp;
            }
        }
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"|{arr[i]}|");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = { 6, 1, 12, 7, -3, 0, 5 };
            PrintArray(arr);
            SelectionSort(arr);
            PrintArray(arr);
        }
    }
}
