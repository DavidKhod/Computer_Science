using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P117Q10to13_28_11_22
{
    class Program
    {
        static void Main(string[] args)//Q10
        {
            string Name;
            double Currentweight, WantedWeight;
            for (int i = 1; i <= 34; i++)
            {
                Console.WriteLine("Enter your name");
                Name = Console.ReadLine();
                Console.WriteLine("Enter your current weight");
                Currentweight = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the weight you want to acomplish within two months");
                WantedWeight = double.Parse(Console.ReadLine());
                double WeightToLose;
                WeightToLose = (Math.Abs(WantedWeight - Currentweight));
                Console.WriteLine($"{Name} has to lose {WeightToLose}");
                if (WeightToLose>Currentweight*0.12)
                {
                    Console.WriteLine("Unhealthy");
                }
            }

        }
    }
}
