using System;

namespace RecurtionWithArray
{
    class Program
    {
        //Entry: The function inputs and array and an integer 'i'
        //Exit: the functions returns True if the array is in an ascending order from the index inputed, False if not
        static bool AscendingOrder(int[] arr, int i)
        {
            if (i == arr.Length-1)
                return true;
            else
                if (arr[i] >= arr[i+1])
                    return false;
                return AscendingOrder(arr, i + 1);
        }

        static int sumOddValues(int[] arr)
        {
            return sumOddValues(arr, 0);
        }

        static int sumOddValues(int[] arr,int i)
        {
            if(i == arr.Length-1)
            {
                if (arr[i] % 2 != 0)
                    return arr[i];
                return 0;
            }
            else
            {
                if (arr[i] % 2 != 0)
                    return sumOddValues(arr, i + 1) + arr[i];
                return sumOddValues(arr, i + 1);
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
