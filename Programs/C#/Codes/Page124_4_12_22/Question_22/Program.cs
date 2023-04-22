using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            for (int i = 1; i <= 300; i++)
            {
                double Squared;
                Squared = Math.Sqrt(i);
                if (Squared % 1 == 0)
                {
                    j++;
                }
            }
            Console.WriteLine($"The number of numbers that their square root is a whole number is {j}");
        }
    }
}
