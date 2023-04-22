using System;

namespace P69Q43
{
    class Program
    {
        /// <summary>
        /// Creates an int Array from the users input
        /// </summary>
        /// <returns>an int Array with the users input</returns>
        static char[] CreatCharArray(int length)
        {
            char[] arr = new char[length];
            Console.WriteLine($"Enter {length} numbers");
            for (int i = 0; i < length; i++)
            {
                arr[i] = char.Parse(Console.ReadLine());
            }
            return arr;
        }

        /// <summary>
        /// Prints the array inputed
        /// </summary>
        /// <param name="arr">The array inputed</param>
        static void PrintArray(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"|{arr[i]}| ");
            }
            Console.WriteLine("");
        }


        static bool Exist(int num, char[] arr)
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
        static char[] FindExisting(int lenght, char[] arr1, char[] arr2)
        {
            char[] temp = new char[lenght];
            int cnt = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j] && Exist(arr2[j], temp) == false)
                    {
                        temp[cnt] = arr1[i];
                        cnt++;
                    }
                }
            }
            char[] inBoth = new char[cnt];
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
            Console.Write("Enter the amount of boats washed last time(1): ");
            amount1 = int.Parse(Console.ReadLine());
            char[] arr1 = CreatCharArray(amount1);
            Console.Write("Enter the amount of boats washed this time(2): ");
            amount2 = int.Parse(Console.ReadLine());
            char[] arr2 = CreatCharArray(amount2);
            int maxLength = Math.Max(arr1.Length, arr2.Length);
            Console.Write("Arr1: ");
            PrintArray(arr1);
            Console.Write("Arr2; ");
            PrintArray(arr2);
            char[] inBoth = FindExisting(maxLength, arr1, arr2);
            Console.Write("Washed both times: ");
            PrintArray(inBoth);
            char[] dontInBothTemp = new char[arr1.Length + arr2.Length];
            int cnt = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (Exist(arr1[i], inBoth) == false)
                {
                    dontInBothTemp[cnt] = arr1[i];
                    cnt++;
                }
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                if (Exist(arr2[i], inBoth) == false)
                {
                    dontInBothTemp[cnt] = arr2[i];
                    cnt++;
                }
            }
            char[] dontInBoth = new char[cnt];
            for (int i = 0; i < dontInBoth.Length; i++)
            {
                if (Exist(dontInBothTemp[i], dontInBoth) == false)
                {
                    dontInBoth[i] = dontInBothTemp[i];
                }
            }
            Console.Write("Boats to wash: ");
            PrintArray(dontInBoth);
        }
    }
}