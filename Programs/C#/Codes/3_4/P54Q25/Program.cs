using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P54Q25
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
        /// Calculates all the odd numbers if the number inputed is odd,all the even numbers if the number inputed is even
        /// </summary>
        /// <param name="arr">The array inputed</param>
        /// <param name="num">The number checking if Even or Odd</param>
        static void PrintEvenOrOdd(int[] arr,int num)
        {
            if (num % 2 == 0)
            {
                string EvenNumbers = "";
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        EvenNumbers += $"|{arr[i]}| ";
                    }
                }
                Console.WriteLine(EvenNumbers);
            }
            else
            {
                string OddNumbers = "";
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        OddNumbers += $"|{arr[i]}| ";
                    }
                }
                Console.WriteLine(OddNumbers);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = CreateRndArray(30,1,10);
            int num = rnd.Next(1,11);
            PrintIntArray(arr);
            Console.WriteLine($"The number randomized: {num}");
            PrintEvenOrOdd(arr,num);
            PrintEvenOrOdd(arr, num + 1);
        }
    }
}
