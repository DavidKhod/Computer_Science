using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P55Q31
{
    class Program
    {
        /// <summary>
        /// Prints the array inputed
        /// </summary>
        /// <param name="arr">The array inputed</param>
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// Creates an int Array from the users input
        /// </summary>
        /// <returns>an int Array with the users input</returns>
        static int[] CreatintArray()
        {
            int length;
            Console.Write("Enter the length of the Array to be created: ");
            length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            Console.WriteLine($"Enter {length} numbers");
            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }

        static int ClosestUp(int[] arr, int placeWanted)
        {
            int seatAvailable = 0;
            bool taken = true;
            for (int i = placeWanted; i < arr.Length && taken; i++)
            {
                if (arr[i] != 1)
                {
                    arr[i] = 1;
                    taken = false;
                    seatAvailable = i;
                }
            }
            return seatAvailable;
        }

        static int ClosestDown(int[] arr, int placeWanted)
        {
            int seatAvailable = 0;
            bool taken = true;
            for (int i = arr.Length; i > placeWanted && taken; i--)
            {
                if (arr[i] != 1)
                {
                    arr[i] = 1;
                    taken = false;
                    seatAvailable = i;
                }
            }
            return seatAvailable;
        }
        static int PlaceClosest(int[]arr,int placeWanted)
        {
            if (ClosestDown(arr,placeWanted) - placeWanted < ClosestUp(arr, placeWanted) - placeWanted)
            {
                return ClosestDown(arr, placeWanted);
            }
            else
            {
                return ClosestUp(arr, placeWanted);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[200];
            for (int i = 0; i < arr.Length; i++)
            {
                int seatWanted;
                Console.WriteLine($"Enter the seat you want");
                seatWanted = int.Parse(Console.ReadLine());
                Console.WriteLine($"You get place {PlaceClosest(arr, seatWanted)}");
            }

        }
    }
}
