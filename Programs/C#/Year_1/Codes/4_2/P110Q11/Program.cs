using System;

namespace P110Q11
{
    class Program
    {
        static Random rnd = new Random();

        static int FindSecretCodeInIndex(int index, int[,] mat)
        {
            return mat[(index - 11) % 10, (index - 11) / 10];
        }

        static void PrintIntMatrix(int[,] mat)
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
            int[,] mat = new int[9, 9];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = rnd.Next(1, 10001);
                }
            }
            PrintIntMatrix(mat);
            int choice;
            Console.Write($"Enter your locker number: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your secret code is: {FindSecretCodeInIndex(choice, mat)}");
        }
    }
}
