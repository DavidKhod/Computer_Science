using System;

namespace P109Q9
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
                    mat[i, j] = rnd.Next(1, 10);
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
                    if (mat[i, j] >= 10)
                    {
                        Console.Write($"|{mat[i, j]}|");
                    }
                    else
                    {
                        Console.Write($"|{mat[i, j]} |");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Changing(int[,] mat)
        {
            int temp;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if(i<j)
                    {
                        temp = mat[i, j];
                        mat[i, j] = mat[j, i];
                        mat[j, i] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[,] newMat = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            PrintMatrix(newMat);
            Console.WriteLine();
            Changing(newMat);
            PrintMatrix(newMat);
            Console.WriteLine($"------------");
            int[,] mat = CreateIntMatrix(4, 4);
            PrintMatrix(mat);
            Console.WriteLine();
            Changing(mat);
            PrintMatrix(mat);
        }
    }
}
