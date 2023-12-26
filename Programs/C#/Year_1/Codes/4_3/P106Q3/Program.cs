using System;

namespace P106Q3
{
    class Program
    {
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
        static Random rnd = new Random();
        static void PrintSumOfRows(int[,] mat)
        {
            int sum = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    sum += mat[i, j];
                }
                Console.WriteLine($"The sum of row {i} is: {sum}");
            }
        }

        static void PrintSumOfCols(int[,] mat)
        {
            int sum = 0;
            for (int i = 0; i < mat.GetLength(1); i++)
            {
                sum = 0;
                for (int j = 0; j < mat.GetLength(0); j++)
                {
                    sum += mat[j, i];
                }
                Console.WriteLine($"The sum of column {i} is: {sum}");
            }
        }

        static int SumOfAreaOfMatrix(int[,] mat)
        {
            int sum = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (j == 0 || j == mat.GetLength(1) - 1 || i == 0 || i == mat.GetLength(0) - 1)
                    {
                        sum += mat[i, j];
                    }
                }
            }
            return sum;
        }

        static int SumOfDiagonal(int[,] mat)
        {
            int sum = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                sum += mat[i, i];
            }
            return sum;
        }

        static int SumOverDiagonal(int[,] mat)
        {
            int sum = 0;
            int sumDiagonal = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                sumDiagonal += mat[i, i];
                for (int j = i; j < mat.GetLength(1); j++)
                {
                    sum += mat[i, j];
                }
            }
            Console.WriteLine($"The sum of the diagonal is: {sumDiagonal}");
            return sum;
        }

        static int SumUnderDiagonal(int[,] mat)
        {
            int sum = 0;
            int sumDiagonal = 0;
            for (int i = 1; i < mat.GetLength(0); i++)
            {
                sumDiagonal += mat[i, i];
                for (int j = 0; j < i; j++)
                {
                    sum += mat[i, j];
                }
            }
            Console.WriteLine($"The sum of the diagonal is: {sumDiagonal}");
            return sum;
        }

        static int SumOppoisiteDiagonal(int[,] mat)
        {
            int sum = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                sum += mat[i, mat.GetLength(1) - 1 - i];
            }
            return sum;
        }

        static int SumUnderOppositeDiagonal(int[,] mat)
        {
            int sum = 0;
            for (int i = 2; i < mat.GetLength(0); i++)
            {
                for (int j = mat.GetLength(0) - 1; j >= mat.GetLength(0) - i; j--)
                {
                    sum += mat[i, j];
                }
            }
            return sum;
        }

        static int SumOverOppositeDiagonal(int[,] mat)
        {
            int sum = 0;
            for (int i = 0; i < mat.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < mat.GetLength(0) - 1 - i; j++)
                {
                    sum += mat[i, j];
                }
            }
            return sum;
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
            int[,] mat = CreateIntMatrix(5, 5);
            PrintMatrix(mat);
            PrintSumOfRows(mat);
            PrintSumOfCols(mat);
            Console.WriteLine($"The sum of the area of the matrix is: {SumOfAreaOfMatrix(mat)}");
            Console.WriteLine($"The sum of the Diagonal of the matrix is: {SumOfDiagonal(mat)}");
            Console.WriteLine($"The sum of the indexes over the Diagonal is: {SumOverDiagonal(mat)}");
            Console.WriteLine($"The sum of the indexes under the Diagonal is: {SumUnderDiagonal(mat)}");
            Console.WriteLine($"The sum of the opposite Diagonal is: {SumOppoisiteDiagonal(mat)}");
            Console.WriteLine($"The sum of indexes under opposite diagonal is: {SumUnderOppositeDiagonal(mat)}");
            Console.WriteLine($"The sum of indexes over opposite Diagonal is: {SumOverOppositeDiagonal(mat)}");
        }
    }
}
