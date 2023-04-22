using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P44Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ARRLENGTH = 5;
            int[] arr = new int[ARRLENGTH];
            Console.Write($"Enter {ARRLENGTH} numbers: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int max = 0, min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"The biggest number is {max}");
            Console.WriteLine($"The smallest number is {min}");
            int maxCnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == max)
                {
                    maxCnt++;
                }
            }
            Console.WriteLine($"The amount of {max}'s in the Array is {maxCnt}");

        }
    }
}
