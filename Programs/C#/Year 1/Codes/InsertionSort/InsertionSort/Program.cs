using System;

namespace InsertionSort
{
    class Program
    {
        /// <summary>
        /// The function inputs a number,the amount of numbers already inputed/exist in the array, and the array itself
        /// </summary>
        /// <param name="num">The number to add to the array</param>
        /// <param name="amountOfInputed">The amount of numbers already inputed/exist in the array</param>
        /// <param name="arr">The array adding to</param>
        static void InsertionSort(int num, int amountOfInputed, int[] arr)
        {
            bool found = false;
            if (amountOfInputed == 0)
            {
                arr[0] = num;
            }
            else if (amountOfInputed < arr.Length)
            {
                for (int i = 0; i < amountOfInputed && !found; i++)
                {
                    if (num < arr[i])
                    {
                        for (int j = amountOfInputed; j > i; j--)
                        {
                            arr[j] = arr[j - 1];
                        }
                        arr[i] = num;
                        found = true;
                    }
                }
                if (!found)
                    arr[amountOfInputed] = num;
            }
        }

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
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter a number: ");
                InsertionSort(int.Parse(Console.ReadLine()), i, arr);
            }
            PrintArray(arr);
        }
    }
}
