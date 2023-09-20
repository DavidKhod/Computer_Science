using System;

namespace RecurtionWithArray
{
    class Program
    {
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
