using System;

namespace P55Q30
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
        /// Finds if there is a series of raising numbers that their length is at least half of the array
        /// </summary>
        /// <param name="arr">The array inputed</param>
        /// <returns>True if there is a series of raising numbers that their length is at least half of the array,False if not</returns>
        static bool IsHalfRaising(int[] arr)
        {
            int cnt = 1, maxCnt = 0;
            int before = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > before)
                {
                    cnt++;
                }
                else
                {
                    cnt = 1;
                }
                if (cnt > maxCnt)
                {
                    maxCnt = cnt;
                }
            }
            if (maxCnt >= arr.Length / 2)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            int[] arr = CreatintArray();
            if (IsHalfRaising(arr))
            {
                Console.WriteLine($"True");
                Console.WriteLine($"The length of the series of numbers that are raising is bigger or equal to the half of the array");
            }
            else
            {
                Console.WriteLine($"false");
                Console.WriteLine($"The length of the series of numbers that are raising is smaller then half of the array");
            }
        }
    }
}
