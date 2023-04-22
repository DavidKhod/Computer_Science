using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P47Q21
{
    class Program
    {
        //Entry claim: Inputs a full positive number
        //Exit claim: Creats an int Array through the input of the user and returns it
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

        //Entry claim: Intputs an int Array
        //Exit claim: Prints the Array
        static void PrintIntArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("");
        }

        static Random rnd = new Random();

        //Entry claim: inputs a three integers,1 the length of the arrat created,2 the smalles number to Randomize from,3 The biggest number to randomize until
        //Exti claim: Creates an int Array for the random number in the feild inputed and returns it
        static int[] PrintRndArray(int length, int from, int until)
        {
            int[] arr = new int[length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(from, until + 1);
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int length;
            int cnt = 0;
            Console.WriteLine("Enter a number dividable by 3");
            length = int.Parse(Console.ReadLine());
            int[] arr = CreatintArray(length);
            PrintIntArray(arr);
            int[] b = new int[arr.Length / 3];
            for (int i = 0; i < arr.Length; i++)
            {

            }
        }
    }
}
