using System;

namespace P69Q42
{

    class Program
    {
        /// <summary>
        /// Creates an int Array from the users input
        /// </summary>
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
        /// The function inputs an integer and an int array and looks for the number within the array
        /// </summary>
        /// <param name="num">The integer looking for</param>
        /// <param name="arr">The array looking within</param>
        /// <returns>True if the integer inputed is found within the array,False if not</returns>
        static bool Exist(int num, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// The function inputs the max length in between the two int array inputed as well, and find the numbers that exist in both of the arrays
        /// </summary>
        /// <param name="lenght">The max length in between both int arrays inputed</param>
        /// <param name="arr1">the first int array inputed</param>
        /// <param name="arr2">the second int array</param>
        /// <returns>An int array with the numbers that exist in both int arrays inputed</returns>
        static int[] FindExisting(int lenght, int[] arr1, int[] arr2)
        {
            int[] temp = new int[lenght];
            int cnt = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (Exist(arr1[i], arr2) && Exist(arr1[i], temp) == false)
                {
                    temp[cnt] = arr1[i];
                    cnt++;
                }
            }
            int[] inBoth = new int[cnt];
            for (int i = 0; i < cnt; i++)
            {
                if (Exist(temp[i], inBoth) == false)
                {
                    inBoth[i] = temp[i];
                }
            }
            return inBoth;
        }
        static void Main(string[] args)
        {
            int amount1;
            int amount2;
            Console.Write("Enter the amount of numbers you want(1): ");
            amount1 = int.Parse(Console.ReadLine());
            int[] arr1 = CreatintArray(amount1);
            Console.Write("Enter the amount of numbers you want(2): ");
            amount2 = int.Parse(Console.ReadLine());
            int[] arr2 = CreatintArray(amount2);
            int maxLength = Math.Max(arr1.Length, arr2.Length);
            PrintArray(arr1);
            PrintArray(arr2);
            PrintArray(FindExisting(maxLength, arr1, arr2));
        }
    }
}