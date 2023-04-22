using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P54Q23
{
    class Program
    {
        /// <summary>
        /// Creates an int Array from the users input
        /// </summary>
        /// <param name="length">The length of the Array to be created</param>
        /// <returns>an int Array with the users input</returns>
        static int[] CreatintArray(int length)
        {
            int[] arr = new int[length];
            Console.WriteLine($"Enter {length} numbers");
            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }


        /// <summary>
        /// Prints the int array inputed
        /// </summary>
        /// <param name="arr">The int array inputed</param>
        static void PrintIntArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("");
        }


        /// <summary>
        /// Calculates the average value between all of the indexes in the Array
        /// </summary>
        /// <param name="arr">The int array inputed</param>
        /// <returns>The average value between all of the indexes in the Array</returns>
        static double ArrayIntAverage(int [] arr)
        {
            int Sum = 0;
            double average;
            for (int i = 0; i < arr.Length; i++)
            {
                Sum += arr[i];
            }
            average = Sum / arr.Length;
            return average;
        }


        /// <summary>
        /// Calculates if the Array inputed is Balanced
        /// </summary>
        /// <param name="arr">The int Array inputed</param>
        /// <returns>True if The array is balanced, False if the Array is not Balanced (Balanced --> The amount of number over the average are equal to the amount of numbers under the average)</returns>
        static bool IsBalanced(int [] arr)
        {
            double avg = ArrayIntAverage(arr);
            int overAvg = 0, underAvg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > avg)
                {
                    overAvg++;
                }
                else if (arr[i] < avg)
                {
                    underAvg++;
                }
            }
            if (overAvg == underAvg)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static void Main(string[] args)
        {
            int length;
            Console.WriteLine("Enter the length of the Array");
            length = int.Parse(Console.ReadLine());
            int[] arr = CreatintArray(length);
            PrintIntArray(arr);
            if (IsBalanced(arr))
            {
                Console.WriteLine($"The Array is balanced");
            }
            else
            {
                Console.WriteLine($"The Array is not balanced");
            }
        }
    }
}
