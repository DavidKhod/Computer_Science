using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P141Q18
{
    class Program
    {
        /// <summary>
        /// Find if the integer inputed exists with the array inputed
        /// </summary>
        /// <param name="num">An integer looking for if exists within the int array</param>
        /// <param name="arr">The int array inputed</param>
        /// <returns>True if the integer exist within the array,False if not</returns>
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
        static void PrintNumberAppearInBothArrays(int[] arr1,int[] arr2)
        {
            int[] arr = new int[arr1.Length + arr2.Length];
            int cnt = 0;
            for (int i = 0; i < Math.Max(arr1.Length,arr2.Length); i++)
            {
                if (Exist(arr1[i],arr2) && !Exist(arr1[i],arr))
                {
                    arr[cnt] = arr[i];
                    cnt++;
                    Console.WriteLine($"{cnt}: {arr1[i]}");
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arr2 = { 1, 3, 5, 7, 9, 11 };
            PrintNumberAppearInBothArrays(arr1, arr2);
        }
    }
}
