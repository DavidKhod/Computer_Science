using System;

namespace P110Q12
{
    class Program
    {
        static int CDBoughtTimes(int[,] mat, int col)
        {
            int cnt = 0;
            for (int i = 0; i < mat.GetLength(1); i++)
            {
                cnt += mat[i, col];
            }
            return cnt;
        }

        static int KidsWithAllCDs(int[,] mat)
        {
            int cnt = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                bool allBought = true;
                for (int j = 0; j < mat.GetLength(1) && allBought == true; j++)
                {
                    if (mat[i, j] != 1)
                    {
                        allBought = false;
                    }
                }
                if (allBought)
                {
                    cnt++;
                }
            }
            return cnt;
        }

        static int AverageBought(int[,] mat)
        {
            int sum = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    sum += mat[i, j];
                }
            }
            return sum / mat.GetLength(0);
        }

        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the amount of kids asked: ");
            n = int.Parse(Console.ReadLine());
            int[,] matSurvey = new int[n, 3];
            for (int i = 0; i < matSurvey.GetLength(0); i++)
            {
                for (int j = 0; j < matSurvey.GetLength(1); j++)
                {
                    Console.Write($"Teen {i + 1}, Enter you decision(0 = no|1 = yes): ");
                    matSurvey[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            int maxCol = 0;
            for (int i = 0; i < matSurvey.GetLength(1); i++)
            {
                if (CDBoughtTimes(matSurvey, i) > CDBoughtTimes(matSurvey, maxCol))
                {
                    maxCol = i;
                }
            }
            Console.WriteLine($"The CD that was bought the most: {maxCol + 1}");
            Console.WriteLine($"The amount of kids with all CDs is: {KidsWithAllCDs(matSurvey)}");
            Console.WriteLine($"The average amount of CDs bougth is: {AverageBought(matSurvey)}");
        }
    }
}
