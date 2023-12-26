using System;

namespace P46Q16
{
    class Program
    {

        //Entry claim: Inputs a full positive number
        //Exit claim: Creats an Array throught the input of the user and returns it
        static int[] CreatArray(int length)
        {
            int[] arr = new int[length];
            Console.WriteLine($"Enter {length} numbers");
            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }

        //Entry claim: intputs an Array out of only different numbers
        //Exit claim: Outputs the numbers that appeared the most and its placement in the Array 
        static void WhichIsMore(int[] arr)
        {
            int num1 = arr[0], num2 = 0;
            bool IsDifferent = false;
            for (int i = 1; i < arr.Length && IsDifferent == false; i++)//Finds the numbers
            {
                if (arr[i] != num1)
                {
                    num2 = arr[i];
                    IsDifferent = true;
                }
            }
            int num1cnt = 0, num2cnt = 0;
            string num1Places = "", num2Places = "";
            for (int i = 0; i < arr.Length; i++)//Finds the amount of appearance of the numbers and their placments
            {
                if (arr[i] == num1)
                {
                    num1cnt++;
                    num1Places += $"|{i}";
                }
                if (arr[i] == num2)
                {
                    num2cnt++;
                    num2Places += $"|{i}";
                }
            }
            if (num1cnt > num2cnt)
            {
                Console.WriteLine($"{num1} is the number with the most appearance in the places {num1Places}| ");
            }
            else
            {
                Console.WriteLine($"{num2} is the number with the most appearance in the places {num2Places}| ");
            }
        }

        static void Main(string[] args)
        {
            int length;
            Console.WriteLine($"What is the length");
            length = int.Parse(Console.ReadLine());
            int[] arr = CreatArray(length);
            WhichIsMore(arr);
        }
    }
}
