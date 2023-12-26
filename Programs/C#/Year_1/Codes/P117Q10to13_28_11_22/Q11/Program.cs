using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number;
            for (int i = 1; i < 51; i++)
            {

                Console.WriteLine("Enter a three digit number");
                Number = int.Parse(Console.ReadLine());
                if ((Number%10 != Number/100) && (Number / 100 != ((Number/10)%10) && ((Number / 10) % 10)!= (Number % 10)))
                {
                    Console.WriteLine(Number);
                }
            }
        }
    }
}
