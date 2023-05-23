using System;

namespace P107Q4
{
    class Program
    {
        static Random rnd = new Random();
        static int[,] CreateIntMatrix(int rows, int cols)
        {
            int[,] mat = new int[rows, cols];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = rnd.Next(1, 11);
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

        static bool IsDiagonalMatrix(int [,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                if (mat[i,i] != 1)
                {
                    return false;
                }
                if (mat[i, mat.GetLength(1) - 1 - i] != 1)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[,] mat = CreateIntMatrix(5, 5);
            int[,] diagonalMat = { { 1, 0, 1 }, { 0, 1, 0 }, { 1, 0, 1 } };
            PrintMatrix(mat);
            Console.WriteLine();
            PrintMatrix(diagonalMat);
            bool isDiagonalMatrix1 = IsDiagonalMatrix(mat);
            bool isDiagonalMatrix2 = IsDiagonalMatrix(diagonalMat);
            if (isDiagonalMatrix1)
            {
                Console.WriteLine($"Mat is a diagonal Matrix");
            }
            else
            {
                Console.WriteLine($"Mat is not a diagonal Matrix");
            }
            if (isDiagonalMatrix2)
            {
                Console.WriteLine($"diagonalMat is a diagonal Matrix");
            }
            else
            {
                Console.WriteLine($"diagonalMat is not a diagoanl Matrix");
            }
        }
    }
}
