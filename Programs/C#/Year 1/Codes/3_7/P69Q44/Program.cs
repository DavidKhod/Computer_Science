using System;

namespace P69Q44
{
    class Program
    {
        /// <summary>
        /// Creates an int Array from the users input
        /// </summary>
        /// <returns>an int Array with the users input</returns>
        static int[] CreatintArray(int length)
        {
            int[] arr = new int[length];
            Console.WriteLine($"Enter {length} codes of flowers");
            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
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

        /// <summary>
        /// Find if the integer inputed exists with the array inputed
        /// </summary>
        /// <param name="num">An integer looking for if exists within the int array</param>
        /// <param name="arr">The int array inputed</param>
        /// <returns>True if the integer exist within the array,False if not</returns>
        static bool Exist(int num, int[] arr)
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

        /// <summary>
        /// Orgenizes the int array inputed so that the values that are not equal to zero will be in the smallest index as possible while keeping the length of the array the same length
        /// </summary>
        /// <param name="arr">The int array inputed</param>
        /// <returns>An int array that the index that their value is grater then zero are in the smallest indexes as possible</returns>
        static int[] Organize(int[] arr)
        {
            int[] Organized = new int[arr.Length];
            int cnt = 0;
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                found = false;
                if (arr[i] == 0)
                {
                    for (int j = i + 1; j < arr.Length && found == false; j++)
                    {
                        if (arr[j] != 0 && Exist(arr[j], Organized) == false)
                        {
                            Organized[cnt] = arr[j];
                            cnt++;
                            found = true;
                        }
                    }
                }
                else
                {
                    if (Exist(arr[i], Organized) == false)
                    {
                        Organized[cnt] = arr[i];
                        cnt++;
                    }
                }
            }
            return Organized;
        }

        static void Main(string[] args)
        {
            int N;
            Console.Write("Enter the amount of flowers in the garden: ");
            N = int.Parse(Console.ReadLine());
            int[] allFlowers = CreatintArray(N);
            PrintArray(allFlowers);
            int[] Flowers2 = new int[allFlowers.Length];
            int cntType1 = 0, cntType2 = 0;
            for (int i = 0; i < allFlowers.Length; i++)
            {
                if (allFlowers[i] / 100 == 1)
                {
                    cntType1++;
                }
                if (allFlowers[i] / 100 == 2)
                {
                    Flowers2[cntType2] = allFlowers[i];
                    cntType2++;
                    allFlowers[i] = 0;
                }
            }
            allFlowers = Organize(allFlowers);
            PrintArray(allFlowers);
            PrintArray(Flowers2);
        }
    }
}
