using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P57Q32
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
            Console.Write("Enter the length of the Array to be created:");
            length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            Console.WriteLine($"Enter {length} numbers");
            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }

        static bool ZigZagError(int[] a)
        {
            int i = 0;
            while (i < a.Length-1)
            {
                if (i % 2 == 0)
                {
                    if (a[i] >= a[i+1])
                        return false;
                }
                else
                {
                    if (a[i] <= a[i+1])
                    {
                        return false;
                    }
                }
                i++;
            }
            return true;
        }

        static bool ZigZag(int[] arr)
        {
            bool ZigZag = true;
            int i = 0;
            while (i < arr.Length-1 && ZigZag)
            {
                if (i % 2 == 0)
                {
                    if (arr[i] >= arr[i + 1])
                        ZigZag = false;
                }
                else
                {
                    if (arr[i] <= arr[i + 1])
                        ZigZag = false;
                }
                i++;
            }
            if (ZigZag)
            {
                return true;
            }
            i = 0;
            ZigZag = true;
            while (i < arr.Length-1 && ZigZag)
            {
                if (i % 2 != 0)
                {
                    if (arr[i] >= arr[i + 1])
                        return false;
                }
                else
                {
                    if (arr[i] <= arr[i + 1])
                        return false;
                }
                i++;
            }
            return ZigZag;
        }

        static void Main(string[] args)
        {
            //A 1,5,3,6,4,8
            //B 8,4,6,3,5,1
            int[] arr = CreatintArray();
            PrintArray(arr);
            Console.Write($"The given function: {ZigZagError(arr)} \n");
            //הפועלה שגויה מכיוון שהיא בודקת רק דרך אחת אם זה זיגזג ת היא בודקת אם המספר הראשון קטן מהשני בהתלחה, ולא גם אם המספר הראשון גדול 
            Console.WriteLine($"The corrected function: {ZigZag(arr)}");
            Console.WriteLine(string.Join(",",arr));
        }
    }
}
