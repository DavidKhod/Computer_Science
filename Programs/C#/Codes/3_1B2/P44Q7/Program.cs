using System;

namespace P44Q7
{
    class Program
    {
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("");
        }
        
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine($"Enter a series of numbers");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("---------------------");
            PrintArray(a);
            Console.WriteLine("---------------------");
            int[] b = new int[a.Length];
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = a[i] * 2;
            }
            PrintArray(b);
        }
    }
}
