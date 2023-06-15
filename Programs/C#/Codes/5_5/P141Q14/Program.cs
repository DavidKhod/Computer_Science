using System;

namespace P141Q14
{
    class Program
    {
        /// <summary>
        /// Find if the integer inputed exists with the array inputed
        /// </summary>
        /// <param name="num">An integer looking for if exists within the int array</param>
        /// <param name="arr">The int array inputed</param>
        /// <returns>True if the integer exist within the array,False if not</returns>
        static bool Exist(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    return true;
                }
            }
            return false;
        }

        static int[] IntoOnlyOnceAppearingNumbersArray(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(!Exist(newArr,arr[i]))
                {
                    newArr[cnt] = arr[i];
                    cnt++;
                }
            }
            int[] toReturn = new int[cnt];
            for (int i = 0; i < toReturn.Length; i++)
            {
                toReturn[i] = newArr[i];
            }
            return toReturn;
        }
        static int[] MergeSortedArr(int[] arr1, int[] arr2)
        {
            int[] newArr = new int[arr1.Length + arr2.Length];
            int cnt = 0;
            int tempNum;
            int min;
            for (int i = 0; i < newArr.Length; i++)
            {
                if (cnt < arr1.Length && cnt < arr2.Length)
                {
                    min = Math.Min(arr1[cnt], arr2[cnt]);
                    if (i - 1 >= 0 && newArr[i - 1] > min)
                    {
                        bool ended = false;
                        newArr[i] = min;
                        int tempI = i;
                        while (tempI > 0 && !ended)
                        {
                            if (tempI - 1 >= 0 && newArr[tempI - 1] > newArr[tempI])
                            {
                                tempNum = newArr[tempI - 1];
                                newArr[tempI - 1] = newArr[tempI];
                                newArr[tempI] = tempNum;
                                tempI--;
                            }
                            else
                                ended = true;
                        }
                    }
                    else
                    {
                        newArr[i] = min;
                    }
                    newArr[i + 1] = Math.Max(arr1[cnt], arr2[cnt]);
                    if (i + 1 < newArr.Length)
                        i++;
                }
                else if (cnt < arr1.Length)
                {
                    newArr[i] = arr1[cnt];
                }
                else
                {
                    newArr[i] = arr2[cnt];
                }
                cnt++;
            }
            int[] toReturn = IntoOnlyOnceAppearingNumbersArray(newArr);
            return toReturn;
        }

        /// <summary>
        /// Prints the array inputed
        /// </summary>
        /// <param name="arr">The array inputed</param>
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"|{arr[i]}| ");
            }
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 1, 6, 7, 8 ,9};
            PrintArray(MergeSortedArr(arr1, arr2));
        }
    }
}
