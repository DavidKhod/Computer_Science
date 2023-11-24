using System;

namespace P51Q8
{
    class Program
    {
        static Random rnd = new Random();
        static int[] CreateRandomArray(int size, int from, int to)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(from, to + 1);
            }
            return arr;
        }

        static int[] CountAllScores(int[] arr)
        {
            int[] allScores = new int[101];
            for (int i = 0; i < arr.Length; i++)
            {
                allScores[arr[i]]++;
            }
            return allScores;
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

        static void PrintCountOfEveryScore(int[] arr)
        {
            int cnt = 0;
            for (int i = 0; i <= 100; i++)
            {
                cnt = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == i)
                        cnt++;
                }
                Console.Write($"|{i}: {cnt} ");
            }
        }
        static void Main(string[] args)
        {
            //Option 1
            int[] scores = CreateRandomArray(40, 0, 100);
            int[] scoresCounter = CountAllScores(scores);
            PrintArray(scores);
            PrintArray(scoresCounter);
            //Option 2
            Console.WriteLine();
            PrintCountOfEveryScore(scores);



        }
    }
}
