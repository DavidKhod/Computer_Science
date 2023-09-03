using System;

namespace Q2
{
    class Program
    {
        static bool IsEqualDiagonal(int[,] mat, int i, int j)
        {
            return mat[i, j] == mat[i + 1, j + 1] && mat[i + 1, j + 1] == mat[i + 2, j + 2];
        }

        static int IsDiagonalEqualTo1(int[,] mat, int i, int j)
        {
            if (IsEqualDiagonal(mat, i, j))
                if (mat[i, j] == 1)
                    return 1;
            return 0;
        }

        static Random rnd = new Random();
        static int[,] CreateRandomIntMatrix(int rows, int cols, int from, int to)
        {
            int[,] mat = new int[rows, cols];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = rnd.Next(from, to + 1);
                }
            }
            return mat;
        }

        static void PrintMatrix(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"|{mat[i, j]}|");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] mat = CreateRandomIntMatrix(6, 7, 0, 1);
            int cnt = 0;
            for (int i = 0; i < mat.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < mat.GetLength(1) - 2; j++)
                {
                    cnt += IsDiagonalEqualTo1(mat, i, j);
                }
            }
            PrintMatrix(mat);
            Console.WriteLine($"The amount of diagonals that are equal to one is: {cnt}");
        }
    }
}
