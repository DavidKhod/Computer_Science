using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void BubbleSort(int[] arr)
        {
            int min;
            int tempnum;
            for (int i = 0; i < arr.Length; i++)
            {
                min = arr[i];
                tempnum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        tempnum = arr[i];
                        arr[i] = min;
                        arr[j] = tempnum;
                    }
                }
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
            BubbleSort(arr);
            PrintArray(arr);
        }
    }
}
