using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P46Q14
{
    class Program
    {
        static int[] CreatArray(int length)
        {
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Enter a number");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] arr = CreatArray(6);
            bool Half = true;
            for (int i = 0; i < arr.Length / 2 && Half; i++)
            {
                if (arr[i] != arr[i + (arr.Length / 2)])
                {
                    Half = false;
                }
            }
            if (Half)
            {
                Console.WriteLine($"Half");
            }
            else
            {
                Console.WriteLine($"Not Half");
            }
        }
    }
}
