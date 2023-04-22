using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q37
{
    class Program
    {
        static void Main(string[] args)
        {
            int RoiSum = 0, TalSum = 0;
            int RoiWIns = 0, TalWins = 0;
            for (int i = 1; i <= 10; i++)
            {
                int RoiBalls = 0, TalBalls = 0;
                Console.WriteLine($"Enter Roi's score in game {i} ");
                RoiBalls = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter Tal's score in game {i} ");
                TalBalls = int.Parse(Console.ReadLine());
                RoiSum += RoiBalls;
                TalSum += TalSum;
                if (RoiBalls>TalBalls)
                {
                    Console.WriteLine($"Roi won round {i}");
                    RoiSum++;
                }
                else
                {
                    Console.WriteLine($"Tal won round {i}");
                    TalWins++;
                }

            }
            if (RoiSum>TalSum)
            {
                Console.WriteLine("Roi got the bigger score overall");
            }
            else if (RoiSum<TalSum)
            {
                Console.WriteLine("tal got the bigger score overall");
            }
            else
            {
                Console.WriteLine("Their score is equal");
            }
            Console.WriteLine($"Roi won {RoiWIns} games");
            Console.WriteLine($"Tal won {TalWins} games");
            
                
           
        }
    }
}
