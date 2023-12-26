using System;
using System.Linq;

namespace Q22
{
    class Program
    {
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"|{matrix[i,j]}|\t");
                }
                Console.WriteLine();
            }
        }

        static Random rnd = new Random();
        static int[,] CreateRandomMatrixWithDiffNumInEachRow(int rows, int cols, int from, int to)
        {
            int num;
            int[,] mat = new int[rows, cols];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                int[] week = new int[6];
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    num = rnd.Next(from, to + 1);
                    while (week.Contains(num))
                    {
                        if (num + 1 <= to)
                            num++;
                        else if (num - 1 >= from)
                            num--;
                    }
                    week[j] = num;
                    mat[i, j] = num;
                }
            }
            return mat;
        }

        static int[] NumberThatWereNotRolledYet(int [,] mat)
        {
            int[] RolledAlready = new int[49];
            int cnt = 0;
            int cntOfUnRolledInWeek;
            int[,] WasntRolled = new int[5, 6];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                cntOfUnRolledInWeek = 0;
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (!RolledAlready.Contains(mat[i, j]))
                    {
                        RolledAlready[cnt] = mat[i, j];
                    }
                }
                for (int j = 0; j < 50 && cntOfUnRolledInWeek < 6; j++)
                {
                    if (!RolledAlready.Contains(j))
                    {
                        WasntRolled[i, cntOfUnRolledInWeek] = j;
                        cntOfUnRolledInWeek++;
                    }
                }
            }
            int[] returns = new int[6];
            for (int i = 0; i < returns.Length; i++)
                returns[i] = WasntRolled[WasntRolled.GetLength(0) - 1, i];
            return returns;
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"|{arr[i]}|");
            }
        }
        static void Main(string[] args)
        {
            int[,] mat = CreateRandomMatrixWithDiffNumInEachRow(5, 6, 1, 49);
            PrintMatrix(mat);
            Console.WriteLine();
            int[] unRolledMat = NumberThatWereNotRolledYet(mat);

            PrintArray(unRolledMat);
            
        }
    }
}
