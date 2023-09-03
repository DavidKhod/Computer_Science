using System;

namespace P46Q18
{
    class Program
    {
        //Entry claim: Intputs an int Array
        //Exit claim: Prints the Array
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("");
        }

        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine($"Enter two numbers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            int min = Math.Min(num1, num2), max = Math.Max(num1, num2);
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(min, max + 1);
            }
            PrintArray(arr);
            int num1cnt = 0, num2cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num1)
                {
                    num1cnt++;
                }
                if (arr[i] == num2)
                {
                    num2cnt++;
                }
            }
            Console.WriteLine($"{num1} was {num1cnt} times,{num2} was {num2cnt} times");
        }
    }
}
