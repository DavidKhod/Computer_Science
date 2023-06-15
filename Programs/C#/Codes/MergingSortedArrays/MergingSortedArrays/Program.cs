using System;

namespace MergingSortedArrays
{
    class Program
    {
        /// <summary>
        /// Input an unsorted Int Array
        /// </summary>
        /// <param name="arr1">The unsorted Int Array</param>
        /// <returns>The Array sorted in a rising order</returns>
        static int[] MergeSelectionSort(int[] arr1, int[] arr2)
        {
            int[] newArr = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                newArr[i] = arr1[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                newArr[i + arr1.Length] = arr2[i];
            }
            int min;
            int indexOfMin;
            for (int i = 0; i < newArr.Length - 1; i++)
            {
                min = newArr[i];
                indexOfMin = i;
                for (int j = i + 1; j < newArr.Length; j++)
                {
                    if (min > newArr[j])
                    {
                        min = newArr[j];
                        indexOfMin = j;
                    }
                }
                int temp = newArr[i];
                newArr[i] = min;
                newArr[indexOfMin] = temp;
            }
            return newArr;
        }

        //static int[] MergeSortedArr(int[] arr1, int[] arr2)
        //{
        //    int[] newArr = new int[arr1.Length + arr2.Length];
        //    for (int i = 0; i < newArr.Length; i++)
        //        newArr[i] = 0;
        //    int cnt = 0;
        //    int tempNum;
        //    int tempI;
        //    bool ended = false;
        //    for (int i = 0; i < newArr.Length - 1; i += 2)
        //    {
        //        ended = false;
        //        if (cnt < arr1.Length)
        //            newArr[i] = arr1[cnt];
        //        if (cnt < arr1.Length && cnt < arr2.Length && arr2[cnt] < arr1[cnt])
        //        {
        //            tempNum = newArr[i];
        //            newArr[i] = arr2[cnt];
        //            newArr[i + 1] = tempNum;
        //            tempI = i;
        //            cnt++;
        //            while (tempI > 0 && !ended)
        //            {
        //                if (newArr[tempI - 1] > newArr[tempI])
        //                {
        //                    tempNum = newArr[tempI - 1];
        //                    newArr[tempI - 1] = newArr[tempI];
        //                    newArr[tempI] = tempNum;
        //                }
        //                else
        //                    ended = true;
        //            }
        //        }
        //        else
        //        {
        //            newArr[i + 1] = arr2[cnt];
        //            cnt++;
        //        }
        //    }
        //    return newArr;
        //}

        static int[] MergeSortedArr(int[] arr1, int[] arr2)
        {
            int[] newArr = new int[arr1.Length + arr2.Length];
            int cnt = 0;
            int tempNum;
            for (int i = 0; i < newArr.Length; i++)
            {
                if (cnt < arr1.Length && cnt < arr2.Length)
                {
                    newArr[i] = Math.Min(arr1[cnt], arr2[cnt]);
                    if(i - 1 >= 0 && newArr[i-1] > newArr[i])
                    {
                        tempNum = newArr[i - 1];
                        newArr[i - 1] = newArr[i];
                        newArr[i] = tempNum;
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
            return newArr;
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
            int[] arr1 = { 6, 8, 11, 12, 16, 19 };
            int[] arr2 = { 5, 10, 14, 15 };
            int[] newArr = MergeSelectionSort(arr1, arr2);
            PrintArray(newArr);
            Console.WriteLine();
            int[] newArr2 = MergeSortedArr(arr1, arr2);
            PrintArray(newArr2);
            int[] arr3 = { 1, 3, 5, 7, 9 };
            int[] arr4 = { 2, 4, 6, 8, 10 };
            PrintArray(MergeSortedArr(arr3, arr4));
            int[] arr5 = { -10, 0, 10, 20, 30 };
            int[] arr6 = { -5, 45, 55, 65, 75 };
            PrintArray(MergeSortedArr(arr5, arr6));
        }
    }
}
