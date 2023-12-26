using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double max, weight;
            string BallColor,MaxBallColor;

            Console.WriteLine("Enter a ball weight:");
            weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter this ball's color");
            BallColor = Console.ReadLine();
            max = weight;
            MaxBallColor = BallColor;

            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine("Enter a ball weight:");
                weight = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter this ball's color");
                BallColor = Console.ReadLine();
                if (weight > max)
                {
                    max = weight;
                    MaxBallColor = BallColor;
                }
                
            }
            Console.WriteLine($"The heaviest ball weight is {max} and its color is {MaxBallColor}");
        }
    }
}
