using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q33
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            for (int i = 1; i <= 30; i++)
            {
                int Number;
                Console.WriteLine("Enter a number");
                Number = int.Parse(Console.ReadLine());
                if (Number >= 10 && Number <= 99 && Number % 2 == 0)
                {
                    j=j+Number;
                }
                
            }
            Console.WriteLine("The sum of the even two digit numbers is "+j);
        }
    }
}
