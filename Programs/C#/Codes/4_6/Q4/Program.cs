using System;
namespace Q4
{
    class Program
    {
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

        static int FindLengthOfChainRow(int[,] mat, int row)
        {
            int cnt = 0;
            bool foundOne = false;
            bool ended = false;
            for (int j = 0; j < mat.GetLength(1) && (!foundOne && !ended || foundOne && !ended); j++)
            {
                if (mat[row, j] == 1 && !foundOne)
                    foundOne = true;
                if (mat[row, j] != 1 && foundOne)
                    ended = true;
                if (mat[row, j] == 1 && foundOne)
                    cnt++;
            }
            return cnt;
        }

        static int FindLengthOfChainCol(int[,] mat, int col)
        {
            int cnt = 0;
            bool foundOne = false;
            bool ended = false;
            for (int i = 0; i < mat.GetLength(0) && (!foundOne && !ended || foundOne && !ended); i++)
            {
                if (mat[i, col] == 1 && !foundOne)
                    foundOne = true;
                if (mat[i, col] != 1 && foundOne)
                    ended = true;
                if (mat[i, col] == 1 && foundOne)
                    cnt++;
            }
            return cnt;
        }

        static int IsSurrounded(int[,] mat,int row,int col)
        {
            if (FindLengthOfChainCol(mat, col) == FindLengthOfChainRow(mat, row))
                return 1;
            return 0;
        }

        static void Main(string[] args)
        {
            int[,] mat = CreateRandomIntMatrix(10, 10, 0, 1);
            PrintMatrix(mat);
            int cnt = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    cnt += IsSurrounded(mat, i, j);
                }
            }
            Console.WriteLine($"The amount of surrounded points is: {cnt}");
        }
    }
}
