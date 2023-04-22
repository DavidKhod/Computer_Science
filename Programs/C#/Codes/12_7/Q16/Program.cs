using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q16
{
    class Program
    {
        static int FakeCoin(int weight)
        {
            if (weight % 10 == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            int i = 1;
            int weight;
            Console.WriteLine("Enter the weight of the sack");
            weight = int.Parse(Console.ReadLine());
            while (FakeCoin(weight) != 0)
            {
                Console.WriteLine("Enter the weight of the sack");
                weight = int.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine($"Sack {i} has a fake coin");
        }
    }
}
