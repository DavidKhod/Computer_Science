using System;

namespace P47Q20
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

        static void Main(string[] args)
        {
            int length;
            Console.WriteLine("Enter the length of The Array");
            length = int.Parse(Console.ReadLine());
            if (length % 2 != 0)
            {
                length += 1;
            }
            int[] arr = CreatintArray(length);
            int[] b = new int[arr.Length + arr.Length / 2];
            int until = 2;
            for (int i = 0; i < b.Length; i++)
            {
                if (i < until)
                {
                    if (i < 2)
                    {
                        b[i] = arr[i];
                    }
                    else
                    {
                        b[i] = arr[i - 2];
                    }
                }
                if (i == until)
                {
                    until += 3;
                    if ((b[i - 1] + b[i - 2]) % 3 == 0)
                    {
                        b[i] = b[i - 1] + b[i - 2];
                    }
                    else
                    {
                        b[i] = 0;
                    }
                }
            }
            PrintIntArray(arr);
            PrintIntArray(b);
            
        }
    }
}
