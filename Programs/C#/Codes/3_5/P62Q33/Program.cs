using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P62Q33
{
    class Program
    {
        /// <summary>
        /// Prints the array inputed
        /// </summary>
        /// <param name="arr">The array inputed</param>
        static void PrintArray(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("");
        }

        static Random rnd = new Random();

        static void Main(string[] args)
        {
            int[] arr = new int[11];
            for (int i = 1; i < 1000; i++)
            {
                arr[rnd.Next(1,11)]++;
            }
            PrintArray(arr);
        }
    }
}