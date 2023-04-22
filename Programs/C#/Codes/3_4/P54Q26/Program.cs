using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P54Q26
{
    class Program
    {
        /// <summary>
        /// Creates an double Array from the users input
        /// </summary>
        /// <returns>an double Array with the users input</returns>
        static double[] CreatdoubleArray(int length)
        {
            double[] arr = new double[length];
            Console.WriteLine($"Enter {length} numbers");
            for (int i = 0; i < length; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }
            return arr;
        }

        /// <summary>
        /// Prints the array inputed
        /// </summary>
        /// <param name="arr">The array inputed</param>
        static void PrintArray(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// Adds 10 procent of each index to the index itself,and has a max value for all of the indexes
        /// </summary>
        /// <param name="arr">The double array inputed</param>
        /// <param name="max">The max value that can be in a index</param>
        static void GradePlus10Pcs(double [] arr,double max)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += arr[i] * 0.10;
                if (arr[i] > max)
                {
                    arr[i] = max;
                }
            }
        }

        /// <summary>
        /// Creates An double array in the length inputed,Raises the values of each index by the index's 10 procent,and prints it
        /// </summary>
        static void CreateClassUpperGrades()
        {
            Console.WriteLine("Enter the size of the class");
            double[] arr = CreatdoubleArray(int.Parse(Console.ReadLine()));
            GradePlus10Pcs(arr, 100);
            PrintArray(arr);
        }

        static void Main(string[] args)
        {
            int length;
            Console.Write("Enter the size of the class: ");
            length = int.Parse(Console.ReadLine());
            double[] arr = CreatdoubleArray(length);
            GradePlus10Pcs(arr,100);
            PrintArray(arr);
            Console.WriteLine("---------------");
            CreateClassUpperGrades();
        }
    }
}
