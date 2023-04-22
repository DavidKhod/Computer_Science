using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q18
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int DoubleTimes = 0,Timestaken = 0;
            while (DoubleTimes != 5)
            {
                int Pair1 = rnd.Next(1,7), pair2 = rnd.Next(1,7);
                Console.WriteLine($"{Pair1} {pair2}");
                if (Pair1 == pair2)
                {
                    DoubleTimes++;
                }
                Timestaken++;
            }
            Console.WriteLine($"The amount of rolls it took is {Timestaken}");
            
        }
    }
}
