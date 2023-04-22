using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P46Q13
{
    
    class Program
    {
        static int[] CreatArray(int length)
        {
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Enter a number");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] arr = CreatArray(5);
            bool risingOrder = true;
            int backNum = arr[0];
            for (int i = 1; i < arr.Length && risingOrder; i++)
            {
                if ((arr[i] > backNum))
                {
                    risingOrder = false;
                }
            }
            if (risingOrder)
            {
                Console.WriteLine($"The numbers are in a rising order");
            }
            else
            {
                Console.WriteLine($"THe numbers are not in a rising order");
            }
        }
    }
}
