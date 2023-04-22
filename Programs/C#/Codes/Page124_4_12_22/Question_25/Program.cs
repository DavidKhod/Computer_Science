using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int Passed = 0;
            double Precentage;
            Console.WriteLine("Enter the amount of people tested");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int SignErrors, OtherErrors;
                Console.WriteLine("Enter the amount of errors done on the signs segment");
                SignErrors = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the amount of errors done in all the other segments");
                OtherErrors = int.Parse(Console.ReadLine());
                if (!(SignErrors + OtherErrors >= 3))
                {
                    Passed++;
                }
            }
            Precentage = Passed * (double)(100.0/n);
            Console.WriteLine($"The amount of people that passed the exam is {Passed}");
            Console.WriteLine($"The precentage of people that passed the exam is {Precentage}%");
        }
    }
}
