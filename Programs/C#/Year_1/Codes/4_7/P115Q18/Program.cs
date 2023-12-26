using System;

namespace P115Q18
{
    class Program
    {
        static void Main(string[] args)
        {
            Shift[,] shifts = new Shift[7, 3];
            for (int i = 0; i < shifts.GetLength(0); i++)
            {
                for (int j = 0; j < shifts.GetLength(1); j++)
                {
                    shifts[i, j] = new Shift();
                }
            }
            int decision = 0;
            int day = 0, shift = 0;
            while (day != -1)
            {
                Console.WriteLine($"--------------------");
                Console.Write($"Enter the day: ");
                day = int.Parse(Console.ReadLine());
                Console.Write($"Enter the shift: ");
                shift = int.Parse(Console.ReadLine());
                Console.Write($"Enter your decision: ");
                decision = int.Parse(Console.ReadLine());
                if (decision == 1)
                {
                    Console.Write($"Enter the name of the manager: ");
                    shifts[day-1, shift-1].Manager = Console.ReadLine();
                }
                if (decision == 2)
                {
                    Console.Write($"Enter the name of the worker: ");
                    shifts[day-1, shift-1].SetWorker(Console.ReadLine());
                }
            }
            for (int i = 0; i < shifts.GetLength(0); i++)
            {
                for (int j = 0; j < shifts.GetLength(1); j++)
                {
                    Console.Write($"|({i+1},{j+1}){shifts[i,j].ToString()}|\n");
                }
                Console.WriteLine();
            }
        }
    }
}
