using System;

namespace P47Q19
{
    class Program
    {
        //Entry claim: Inputs a full positive number
        //Exit claim: Creats an String Array throught the input of the user and returns it
        static char[] CreatcharArray(int length)
        {
            char[] arr = new char [length];
            Console.WriteLine($"Enter {length} Letters");
            for (int i = 0; i < length; i++)
            {
                arr[i] = char.Parse(Console.ReadLine());
            }
            return arr;
        }

        //Entry claim: Intputs an string Array
        //Exit claim: Prints the Array
        static void PrintcharArray(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("");
        }

        static public bool IsThereChar(char[] arr, char letter)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == letter)
                {
                    return true;
                }
            }
            return false;
        }

        //Entry claim: Inputs a char Array
        //Exit claim: Outputs the letters form the small abc that are not within the array
        static void NotThereLetters(char [] arr)
        {
            string diffLetter = "";
            for (char i = 'a'; i <= 'z'; i++)
            {
                if (IsThereChar(arr,i) == false)
                {
                    diffLetter += $"|{i}";
                }
            }
            for (char i = 'A'; i <= 'Z'; i++)
            {
                if (IsThereChar(arr, i) == false)
                {
                    diffLetter += $"|{i}";
                }
            }
            Console.WriteLine($"{diffLetter}|");
        }

        static void Main(string[] args)
        {
            int length;
            Console.WriteLine("Enter the length of the array");
            length = int.Parse(Console.ReadLine());
            char[] arr = CreatcharArray(length);
            PrintcharArray(arr);
            NotThereLetters(arr);
        }
    }
}
