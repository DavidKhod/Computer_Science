using System;

namespace P111Q14
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
                Console.Write($"|{arr[i]}| ");
            }
            Console.WriteLine("");
        }

        static bool Exist(int num, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                    return true;
            }
            return false;
        }
        static int[] FindAllNums(int[,] mat)
        {
            int[] tempArr = new int[mat.GetLength(0) * mat.GetLength(1)];
            int cnt = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (!Exist(mat[i, j], tempArr))
                    {
                        tempArr[cnt] = mat[i, j];
                        cnt++;
                    }
                }
            }
            int[] arr = new int[cnt];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = tempArr[i];
            }
            return arr;
        }

        static void Main(string[] args)
        {
            int m;
            Console.Write($"Enter the size of the Matrix: ");
            m = int.Parse(Console.ReadLine());
            int[,] mat = new int[m, m];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"({i},{j})Enter a number: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            PrintArray(FindAllNums(mat));
        }
    }
}
