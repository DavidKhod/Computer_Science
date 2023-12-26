using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P43Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            //A
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
            //B
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter a number for an index");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("--------------------");
            //C
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} ");
            }
            Console.WriteLine("--------------------");
            //D
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"{arr[i]} ");
            }
            Console.WriteLine("--------------------");
            //E
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{arr[i]} ");
                }
            }
            Console.WriteLine("\n--------------------");
            //F
            for (int i = 0; i < arr.Length; i++)
            {
                if (!(i % 2 == 0))
                {
                    Console.Write($"{arr[i]} ");
                }
            }
            Console.WriteLine("\n--------------------");
            //G
            for (int i = 0; i < arr.Length; i++)
            {
                if (!(arr[i] % 2 == 0))
                {
                    Console.Write($"{arr[i]} ");
                }
            }
        }
    }
}
