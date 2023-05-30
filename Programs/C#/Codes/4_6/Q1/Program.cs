using System;

namespace Q1
{
    class Program
    {
        /// <summary>
        /// the function checks whether a particular 3x3 sub-matrix in the given matrix has a sum greater than the num inputed
        /// </summary>
        /// <param name="mat">The matrix looking through</param>
        /// <param name="num">the num checking with</param>
        /// <param name="i">The row of the top left of the 3x3 matrix</param>
        /// <param name="j">The column of the top left of the 3x3 matrix</param>
        /// <returns></returns>
        static bool IsFlaring(int[,] mat, int num, int i, int j)
        {
            return mat[i, j] + mat[i, j + 1] + mat[i, j + 2] + mat[i + 1, j] + mat[i + 1, j + 1] + mat[i + 1, j + 2] + mat[i + 2, j] + mat[i + 2, j + 1] + mat[i + 2, j + 2] > num;
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
            int[,] mat = CreateRandomIntMatrix(6, 7, 1, 10);
            int num;
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            int cnt = 0;
            for (int i = 0; i < mat.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < mat.GetLength(1) - 2; j++)
                {
                    if (IsFlaring(mat, num, i, j))
                        cnt++;
                }
            }
            PrintMatrix(mat);
            Console.WriteLine($"The amount of flaring boxes(the sum of the box is greater that {num}) within the matrix is: {cnt}");
        }
    }
}
