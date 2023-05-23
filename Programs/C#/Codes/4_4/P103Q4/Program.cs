using System;

namespace P103Q4
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

        static bool IsDiagonalsInSameOrder(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                if (mat[i, i] != mat[i, mat.GetLength(1) - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[,] mat = CreateIntMatrix(3, 3);
            int[,] mat2 = { { 1, 0, 1 }, { 0, 2, 0 }, { 3, 0, 3 } };
            PrintMatrix(mat);
            Console.WriteLine();
            PrintMatrix(mat2);
            bool diagonalMat = IsDiagonalsInSameOrder(mat);
            bool diagonalMat2 = IsDiagonalsInSameOrder(mat2);
            if(diagonalMat)
                Console.WriteLine($"Mat's diagonals are in the same order");
            else
                Console.WriteLine($"Mat's diagonals aren't is the same order");
            if (diagonalMat2)
                Console.WriteLine($"Mat2's diagonals are in the same order");
            else
                Console.WriteLine($"Mat2's diagonals aren't is the same order");
        }
    }
}
