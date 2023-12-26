using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P45Q9
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
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double avg = sum / arr.Length;
            Console.WriteLine($"The average number is {avg}");
            int diffAvgCnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != avg)
                {
                    diffAvgCnt++;
                }
            }
            Console.WriteLine($"The amount of numbers that are different form the averag is {diffAvgCnt}");
        }
    }
}
