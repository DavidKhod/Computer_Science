using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            //א
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("$");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("----------");

            //ב
            for (int i = 4; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }

            Console.WriteLine("----------------");
            //ג
            string Number = "";
            int U = 0;
            for (int i = 1; i <= 5; i++)
            {
                Number += i;
                Console.WriteLine(Number);
                U++;
            }

            Console.WriteLine("------------------");

            //ד
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine("");
            }
        }
    }
}
