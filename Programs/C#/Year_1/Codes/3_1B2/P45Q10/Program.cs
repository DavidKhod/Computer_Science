using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P45Q10
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
            int sumEven = 0, sumOdd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sumEven += arr[i];
                }
                else
                {
                    sumOdd += arr[i];
                }
            }
            if (sumEven == sumOdd)
            {
                Console.WriteLine($"The sum of the odd and even numbers is the same");
            }
            else
            {
                Console.WriteLine($"The sum of the odd and even numbers is different");
            }
        }
    }
}
