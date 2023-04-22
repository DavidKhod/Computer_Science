using System;

namespace P69Q41
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

        static void Main(string[] args)
        {
            int N;
            Console.Write("Enter the amount of numbers you want to input: ");
            N = int.Parse(Console.ReadLine());
            int[] numbers = CreatintArray(N);
            int evenCnt = 0, negCnt = 0;
            int[] evenTemp = new int[N];
            int[] negTemp = new int[N];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (numbers[i] < 0)
                    {
                        evenTemp[evenCnt] = numbers[i];
                        negTemp[negCnt] = numbers[i];
                        evenCnt++;
                        negCnt++;
                    }
                    else
                    {
                        evenTemp[evenCnt] += numbers[i];
                        evenCnt++;
                    }
                }
                if (numbers[i] < 0 && numbers[i] % 2 != 0)
                {
                    negTemp[negCnt] += numbers[i];
                    negCnt++;
                }
            }
            int[] even = new int[evenCnt];
            int[] neg = new int[negCnt];
            for (int i = 0; i < evenCnt; i++)
            {
                even[i] = evenTemp[i];
            }
            for (int i = 0; i < negCnt; i++)
            {
                neg[i] = negTemp[i];
            }
            PrintArray(even);
            PrintArray(neg);
        }
    }
}
