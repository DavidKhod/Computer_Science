using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.Green;
            int Kid1, Kid2, Kid3;
            Console.WriteLine("Enter the age of the first kid");
            Kid1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the age of the second kid");
            Kid2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the age of the third kid");
            Kid3 = int.Parse(Console.ReadLine());
            if (Kid1 == Kid2 && Kid1 < Kid3)
            {
                Console.WriteLine("The youngest kids are the first and the second");
            }
            else if (Kid1 == Kid3 && Kid1 < Kid2)
            {
                Console.WriteLine("The youngest kids are the first and the third");
            }
            else if (Kid2 == Kid3 && Kid2 < Kid1)
            {
                Console.WriteLine("The youngest kids are the second and the third");
            }
            else
            {
                if (Kid1 < Kid2 && Kid1 < Kid3)
                {
                    Console.WriteLine("The youngest kid is the first");
                }
                else if (Kid2 < Kid1 & Kid2 < Kid3)
                {
                    Console.WriteLine("The youngest kid is the second");
                }
                else if (Kid3 < Kid1 && Kid3 < Kid2)
                {
                    Console.WriteLine("The youngest kid is the third");
                }
                else if (Kid1==Kid2&&Kid2==Kid3)
                {
                    Console.WriteLine("The age of the first, the second and the third kid is the same");
                }
            }
        }
    }
}
