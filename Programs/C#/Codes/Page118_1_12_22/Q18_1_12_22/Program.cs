using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q18_1_12_22
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                int SumGoals;
                Console.Write("Enter the amount of goals this player did within three rounds: ");
                SumGoals = int.Parse(Console.ReadLine());
                Console.WriteLine($"Player {i},Average Goal number={SumGoals/3}");
                if (SumGoals==0)
                {
                    Console.WriteLine("Didn't score at all");
                }
                if (SumGoals>=5)
                {
                    Console.WriteLine("Excelent player");
                }

            }
        }
    }
}
