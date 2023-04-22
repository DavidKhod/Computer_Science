using System;

namespace P62Q37
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
                Console.Write($"|{i}: {arr[i]}| ");
            }
            Console.WriteLine("");
        }

        static int[] startWithZero(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
            return arr;
        }

        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int grade = 0;
            int[] grades = new int[101];
            int[] gradecnt = new int[11];
            grades = startWithZero(grades);
            gradecnt = startWithZero(gradecnt);
            for (int i = 1; i <= 200; i++)
            {
                grade = rnd.Next(0, 101);
                grades[grade]++;
                gradecnt[grade / 10]++;
            }
            PrintArray(grades);
            PrintArray(gradecnt);
            int max = 0, maxplace = gradecnt[0];
            for (int i = 1; i < gradecnt.Length; i++)
            {
                if (gradecnt[i] > max)
                {
                    max = gradecnt[i];
                    maxplace = i;
                }
            }
            string biggestdiff = $"{maxplace * 10} - {((maxplace + 1)*10)-1}";
            Console.WriteLine(biggestdiff);

        }
    }
}
