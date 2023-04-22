using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page136_Q42
{
    class Program
    {
        static void Main(string[] args)
        {
            double Max = 0;
            for (int i = 1; i <= 8; i++)
            {
                double Length;
                Console.WriteLine($"Enter the length of the jumt of student {i}");
                Length = double.Parse(Console.ReadLine());
                if (Length>Max)
                {
                    Max = Length;
                }
            }
            Console.WriteLine($"The longest jumt out of the whole group is {Max}");
        }
    }
}
