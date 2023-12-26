using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page118_1_12_22
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)//Question 14
        {
            int Number1;
            Console.WriteLine("Enter a number between 10-20");
            Number1 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 30; i++)
            {
                int Number, Difference;
                Number = rnd.Next(10,21);
                Difference = Math.Abs(Number-Number1);
                if (Difference<=4)
                {
                    Console.WriteLine(Number);
                }
            }
        }
    }
}
