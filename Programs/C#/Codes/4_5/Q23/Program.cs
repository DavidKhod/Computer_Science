using System;

namespace Q23
{
    class Program
    {
        static bool IsMaxAround(int[,] mat, int row, int column)
        {
            int max = 0;
            max = Math.Max(mat[row, column - 1], mat[row, column - 1]);
            for (int i = 0; i < 3; i++)
            {
                int maybeMax = Math.Max(mat[row - 1, column - 1 + i], mat[row + 1, column - 1 + i]);
                if (maybeMax > max)
                    max = maybeMax;
            }
            if (Math.Max(max, mat[row, column]) == mat[row, column])
                return true;
            return false;
        }

        static bool IsMaxAroundTop(int[,] mat, int row, int column)
        {
            int max = 0;
            max = Math.Max(mat[row, column - 1], mat[row, column - 1]);
            max = Math.Max((Math.Max(mat[row + 1, column - 1], mat[row + 1, column])), mat[row + 1, column + 1]);
            max = Math.Max(mat[row, column], max);
            if (max == mat[row, column])
                return true;
            return false;
        }

        static bool IsMaxAroundBottom(int[,] mat, int row, int column)
        {
            int max = 0;
            max = Math.Max(mat[row, column - 1], mat[row, column - 1]);
            max = Math.Max((Math.Max(mat[row - 1, column - 1], mat[row - 1, column])), mat[row - 1, column + 1]);
            max = Math.Max(mat[row, column], max);
            if (max == mat[row, column])
                return true;
            return false;
        }

        static bool IsMaxAroundSideLeft(int[,] mat, int row, int column)
        {
            int max = 0;
            max = Math.Max(mat[row - 1, column], mat[row + 1, column]);
            max = Math.Max((Math.Max(mat[row, column + 1], mat[row - 1, column + 1])), mat[row + 1, column + 1]);
            max = Math.Max(max, mat[row, column]);
            if (max == mat[row, column])
                return true;
            return false;
        }

        static bool IsMaxAroundSideRight(int[,] mat, int row, int column)
        {
            int max = 0;
            max = Math.Max(mat[row - 1, column], mat[row + 1, column]);
            max = Math.Max((Math.Max(mat[row, column - 1], mat[row - 1, column - 1])), mat[row + 1, column - 1]);
            max = Math.Max(max, mat[row, column]);
            if (max == mat[row, column])
                return true;
            return false;
        }

        static int sumOfWinningIndexes(int[,] mat)
        {
            int sum = 0;
            for (int i = 1; i < mat.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < mat.GetLength(1) - 1; j++)
                {
                    if (IsMaxAround(mat, i, j))
                        sum += mat[i, j];
                }
            }
            for (int i = 1; i < mat.GetLength(0) - 1; i++)
            {
                if (IsMaxAroundTop(mat, 0, i))
                    sum += mat[0, i];
                if (IsMaxAroundBottom(mat, mat.GetLength(0) - 1, i))
                    sum += mat[mat.GetLength(0) - 1, i];
                if (IsMaxAroundSideLeft(mat, i, 0))
                    sum += mat[i, 0];
                if (IsMaxAroundSideRight(mat, i, mat.GetLength(0) - 1))
                    sum += mat[i, mat.GetLength(0) - 1];
            }
            int border = mat.GetLength(0) - 1;
            int topLeft = Math.Max((Math.Max(Math.Max(mat[0, 1], mat[1, 0]), mat[1, 1])), mat[0, 0]);//Top Left
            int bottomLeft = Math.Max((Math.Max(Math.Max(mat[border, 1], mat[border - 1, 0]), mat[border - 1, 1])), mat[border, 0]);//Bottom Left
            int topRight = Math.Max((Math.Max(Math.Max(mat[0, border - 1], mat[1, border]), mat[1, border - 1])), mat[0, border]);//Top Right
            int bottomRight = Math.Max((Math.Max(Math.Max(mat[border, border - 1], mat[border - 1, border]), mat[border - 1, border - 1])), mat[border, border]);//Bottom Right
            if (topLeft == mat[0, 0])
                sum += mat[0, 0];
            if (bottomLeft == mat[border, 0])
                sum += mat[border, 0];
            if (topLeft == mat[0, border])
                sum += mat[0, border];
            if (bottomRight == mat[border, border])
                sum += mat[border, border];
            return sum;
        }
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
       {
            { 2, 4, 6, 8 },
            { 1, 5, 9, 3 },
            { 7, 5, 3, 1 },
            { 6, 2, 8, 4 }
       };
            PrintMatrix(matrix);
            Console.WriteLine($"Sum of Winning Indexes: {sumOfWinningIndexes(matrix)}");
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"|{matrix[i,j]}|");
                }
                Console.WriteLine();
            }
        }
    }
}
