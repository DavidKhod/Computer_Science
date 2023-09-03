using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page136_Q43
{
    class Program
    {
        static void Main(string[] args)
        {
            double min=1, max=1;
            Console.WriteLine("Insert the height of plant 1");
            double height1 = double.Parse(Console.ReadLine());
            height1 = max;
            height1 = min;
            for (int i = 2; i <= 10; i++)
            {
                double height;
                Console.WriteLine($"Insert the height of plant {i}");
                height = double.Parse(Console.ReadLine());
                if (height>max)
                {
                    max = height;
                }
                if (height < min)
                {
                    min = height;
                }
            }
            Console.WriteLine($"Maximum = {max}");
            Console.WriteLine($"Minimum = {min}");
        }
    }
}
