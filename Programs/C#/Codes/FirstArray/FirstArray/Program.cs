using System;

namespace FirstArray
{
    class Program
    {
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            // יצירת מערך של מספרים באורך של 6
            int[] arr = new int[6];

            arr[0] = 3;//מכניס ערך 3 למקום הראשון במערך
            arr[1] = 5;
            //Console.WriteLine($"{arr[0]}");
            //Console.WriteLine($"{arr[1]}");
            //Console.WriteLine($"{arr[2]}");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter number for index");
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

        }
    }
}
