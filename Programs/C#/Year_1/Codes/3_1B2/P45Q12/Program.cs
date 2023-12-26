using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P45Q12
{
    class Program
    {
        static int[] CreatArray(int length)
        {
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Enter a number");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] arr = CreatArray(5);
            bool IsEqualsNums = true;
            int backNum = arr[0];
            for (int i = 1; i < arr.Length && IsEqualsNums; i++)
            {
                if (arr[i] != backNum)
                {
                    IsEqualsNums = false;
                }
            }
            if (IsEqualsNums)
            {
                Console.WriteLine($"All of the numbers in the array are equal");
            }
            else
            {
                Console.WriteLine($"Not all of the numbers are equal");
            }
        }
    }
}
