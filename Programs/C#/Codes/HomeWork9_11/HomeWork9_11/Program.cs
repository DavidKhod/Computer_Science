using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int Max = 0;
            for (int i = 1; i <= 5; i++)
            {
                int Price;
                Console.WriteLine($"Enter the price of phone {i} ");
                Price = int.Parse(Console.ReadLine());
                if (Price>Max)
                {
                    Max = Price;
                }
            }
            Console.WriteLine($"The highest price is : {Max}");
        }
    }
}
