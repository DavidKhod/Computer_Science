using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q16
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int weight;
            Console.WriteLine("Enter the weight of the sack");
            weight = int.Parse(Console.ReadLine());
            while (weight % 10 == 0)
            {
                i++;
                Console.WriteLine("Enter the weight of the sack");
                weight = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Sack {i} has a fake coin");
        }
    }
}
