using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P43Q24
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
                Console.Write($"|{arr[i]}| ");
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// Finds the numbers that are smaller then the number after them, and prints them
        /// </summary>
        /// <param name="arr">The int Array inputed</param>
        static void SmallerThenAfter(int[] arr)
        {
            string smaller = "";
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    smaller += $"|{arr[i]}| ";
                }
            }
            Console.WriteLine($"{smaller}");
        }

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

        static void Main(string[] args)
        {
            //א
            int length;
            Console.Write("Enter the length of the Array: ");
            length = int.Parse(Console.ReadLine());
            int [] arr = CreatintArray(length);
            SmallerThenAfter(arr);
            //ב
            int[] arr2 = CreateRndArray(20, 1, 10);
            PrintIntArray(arr2);
            Console.WriteLine("");
            SmallerThenAfter(arr2);
            //יכול להיות רק 19 אפשריות
        }
    }
}
