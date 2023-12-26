using System;

namespace P110Q13
{
    class Program
    {
        /// <summary>
        /// Finds the biggest number in a row in a matrix
        /// </summary>
        /// <param name="row">the row looking through</param>
        /// <param name="mat">the matrix looking through</param>
        /// <returns>The biggest number in the row inputed in the matrix inputed</returns>
        static int FindBiggestInRow(int row, int[,] mat)
        {
            int max = 0;
            for (int i = 1; i < mat.GetLength(1); i++)
            {
                if (mat[row, i] > max)
                {
                    max = mat[row, i];
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            int[,] mat = new int[4, 6]
            { {9, 15, 23, 18, 15, 20},
            { 21, 20, 19, 17, 34, 22},
            { 30, 28, 25, 19, 29, 19},
            { 14, 16, 23, 22, 21, 23}};
            int min = FindBiggestInRow(0, mat);
            int temp;
            for (int i = 1; i < mat.GetLength(0); i++)
            {
                temp = FindBiggestInRow(i, mat);
                if (temp < min)
                    min = temp;
            }
            string BiggestSmallestGroups = "";
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] == min)
                        BiggestSmallestGroups += $"|Group {j + 1},battalion {i + 1}|\n";
                }
            }
            Console.WriteLine(BiggestSmallestGroups);
        }
    }
}
