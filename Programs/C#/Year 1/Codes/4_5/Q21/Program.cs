using System;

namespace Q21
{
    class Program
    {
        static bool IsCubeMagical(int[,] mat)
        {
            int[] cnts = new int[6];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                cnts[0] += mat[0, i];
                cnts[1] += mat[mat.GetLength(0) - 1, i];
                cnts[2] += mat[i, i];
                cnts[3] += mat[i, mat.GetLength(0) - 1 - i];
                cnts[4] += mat[i, 0];
                cnts[5] += mat[i, mat.GetLength(0) - 1];
            }
            for (int i = 1; i < cnts.Length; i++)
                if (cnts[i] != cnts[0])
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            int[,] magicCube = new int[,]
          {
            { 2, 7, 6 },
            { 9, 5, 1 },
            { 4, 3, 8 }
          };
            Console.WriteLine($"Is the cube magical? {IsCubeMagical(magicCube)}");
        }
    }
}
