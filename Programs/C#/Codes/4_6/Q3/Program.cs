using System;
namespace Q3
{
    class Program
    {
        static bool IsSumOfUnderRightOfPointEqualToOverLeft(int[,] mat, int row, int col)
        {
            int sumOfUnderRight = 0;
            for (int i = row + 1; i < mat.GetLength(0); i++)
            {
                for (int j = col + 1; j < mat.GetLength(1); j++)
                {
                    sumOfUnderRight += mat[i, j];
                }
            }
            int sumOfOverLeft = 0;
            for (int i = mat.GetLength(0) - 1 - row; i >= 0; i--)
            {
                for (int j = mat.GetLength(1) - 1 - col; j >= 0; j--)
                {
                    sumOfOverLeft += mat[i, j];
                }
            }
            return sumOfOverLeft == sumOfUnderRight;
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
            int[,] mat = CreateRandomIntMatrix(6, 7, 1, 5);
            PrintMatrix(mat);
            string print = "";
            for (int i = 1; i < mat.GetLength(0)-1; i++)
            {
                for (int j = 1; j < mat.GetLength(1)-1; j++)
                {
                    if (IsSumOfUnderRightOfPointEqualToOverLeft(mat, i, j))
                        print += $"|{i},{j}|";
                }
            }
            if (print == "")
                print = "none";
            Console.WriteLine($"All of the indexes with their sum of box over to the left is equal to the box of under to the right is: {print}");

        }
    }
}
