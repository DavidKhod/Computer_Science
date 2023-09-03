using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P46Q22
{
    class Program
    {
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

        /// <summary>
        /// The function organizes the function inputed so that the negative numbers would be first in the array the positive numbers would be after them
        /// </summary>
        /// <param name="arr">The int array inputed</param>
        /// <returns>An int array with the negative numbers first and then the positive numbers after them </returns>
        static int[] OrgenizeNegToPos(int[] arr)
        {
            int[] b = new int[arr.Length];
            int cnt = 0, cntminus = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    b[cnt] = arr[i];
                    cnt++;
                }
                if (arr[i] > 0)
                {
                    b[(b.Length - 1) - cntminus] = arr[i];
                    cntminus++;
                }
            }
            return b;
        }

        static void Main(string[] args)
        {
            int[] arr = CreatintArray();
            int[] b = OrgenizeNegToPos(arr);
            PrintArray(arr);
            PrintArray(b);
        }
    }
}
