using System;

namespace P55Q28
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
        /// Finds the most significant digit of a number
        /// </summary>
        /// <param name="num">The number finding the significant digit of</param>
        /// <returns>The most significant digit of the number inputed</returns>
        static int FindMostSign(int num)
        {
            int temp = num;
            while (temp / 10 == 0)
            {
                temp /= 10;
            }
            return num;
        }

        /// <summary>
        /// Checks if the array inputed is special(The most significant digit of an index is the same as the last number of the index after it)
        /// </summary>
        /// <param name="arr">The array checked</param>
        /// <returns>True if special,False if not special</returns>
        static bool IsSpecial(int[] arr)
        {
            bool special = true;
            for (int i = 0; i < arr.Length-1 && special; i++)
            {
                if (!(arr[i] % 10 == FindMostSign(arr[i + 1])))
                {
                    special = false;
                }
            }
            return special;
        }

        static void Main(string[] args)
        {
            int[] arr = CreatintArray();
            PrintArray(arr);
            if (IsSpecial(arr))
            {
                Console.WriteLine($"The array is special(The most significant digit of an index is the same as the last number of the index after i)");
            }
            else
            {
                Console.WriteLine($"The array is not special(The most significant digit of an index is the same as the last number of the index after i)");
            }
        }
    }
}
