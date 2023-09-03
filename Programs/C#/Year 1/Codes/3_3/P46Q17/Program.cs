using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P46Q17
{
    class Program
    {
        //Entry claim: Inputs a full positive number
        //Exit claim: Creats an int Array throught the input of the user and returns it
        static int[] CreatintArray(int length)
        {
            int[] arr = new int[length];
            Console.WriteLine($"Enter {length} numbers");
            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int num, length;
            Console.WriteLine("Enter the length of the Array");
            length = int.Parse(Console.ReadLine());
            int[] arr = CreatintArray(length);
            Console.WriteLine($"Enter a number");
            num = int.Parse(Console.ReadLine());
            string outPut = "";
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] * arr[j] == num)
                    {
                        outPut += $"({arr[i]},{arr[j]}) ";
                    }
                    if (arr[i] + arr[j] == num)
                    {
                        outPut += $"({arr[i]},{arr[j]}) ";
                    }
                }
            }
            Console.WriteLine(outPut);
        }
    }
}
