using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P55_Q28
{
    class Program
    {
        /// <summary>
        /// Prints the array inputed
        /// </summary>
        /// <param name="arr">The array inputed</param>
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// Creates an int Array from the users input
        /// </summary>
        /// <returns>an int Array with the users input</returns>
        static int[] CreatintArray()
        {
            int length;
            Console.Write("Enter the length of the Array to be created: ");
            length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            Console.WriteLine($"Enter {length} numbers");
            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }

        /// <summary>
        /// Finds the longest series of numbers within the array
        /// </summary>
        /// <param name="arr">The array inputed</param>
        /// <returns>The length of the longest series of numbers</returns>
        static int LongestSameNum(int [] arr)
        {
            int maxCnt = 0, cnt = 1;
            int currentnum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == currentnum)
                {
                    cnt++;
                }
                else
                {
                    currentnum = arr[i];
                    cnt = 1;
                }
                if (cnt > maxCnt)
                {
                    maxCnt = cnt;
                }
            }
            return maxCnt;
        }

        static void Main(string[] args)
        {
            int[] arr = CreatintArray();
            PrintArray(arr);
            Console.WriteLine($"{LongestSameNum(arr)} is the longest series of numbers");
        }
    }
}
