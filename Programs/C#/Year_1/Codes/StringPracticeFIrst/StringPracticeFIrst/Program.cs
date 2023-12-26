using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPracticeFIrst
{
    class Program
    {
        /// <summary>
        /// The function input two strings and print the longest sting,if they're equal then both
        /// </summary>
        /// <param name="str1">the first string</param>
        /// <param name="str2">the second string</param>
        public static void LongestStr1(string str1,string str2)
        {
            if(str1.Length > str2.Length)
                Console.WriteLine(str1);
            if(str1.Length < str2.Length)
                Console.WriteLine(str2);
            Console.WriteLine($"{str1} , {str2}");
        }
        /// <summary>
        /// The function input two string
        /// </summary>
        /// <param name="str1">the first string</param>
        /// <param name="str2">The first string</param>
        /// <returns>The longest string if not equal, if equal then return a new string of both with a space in between</returns>
        static string LongestStr2(string str1,string str2)
        {
            if (str1.Length > str2.Length)
                return str1;
            if (str1.Length < str2.Length)
                return str2;
            return $"{str1} {str2}";
        }
        /// <summary>
        /// Inputs a string and prints the reverse of this string
        /// </summary>
        /// <param name="str">The string inputed</param>
        static void PrintReverseStr(string str)
        {
            for (int i = str.Length-1; i >= 0; i--)
            {
                Console.Write($"{str[i]}");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Inputs a string and reverses it
        /// </summary>
        /// <param name="str">The string reversing</param>
        /// <returns>The string in reverse</returns>
        static string ReverseStr(string str)
        {
            string newStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                newStr += $"{str[i]}";
            }
            return newStr;
        }
        /// <summary>
        /// Inputs a string and print the zigzag of it, the first char with the last, the second with the second last and so on
        /// </summary>
        /// <param name="str"></param>
        public static void PrintZigZag(string str)
        {
            for (int i = 0; i < str.Length/2; i++)
            {
                Console.Write($"{str[i]}{str[str.Length-1-i]}");
            }
            if (str.Length % 2 != 0)
            {
                Console.Write($"{str[str.Length - str.Length/2-1]}");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Input a string
        /// </summary>
        /// <param name="str">The string inputed</param>
        /// <returns>The char with the biggest value</returns>
        public static char MaxChar(string str)
        {
            char max = str[0];
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i].CompareTo(max) < 0)
                {
                    max = str[i];
                }
            }
            return max;
        }
        /// <summary>
        /// The function inputs a string
        /// </summary>
        /// <param name="str">The string inputed</param>
        /// <returns>The index of the char with the smallest value</returns>
        public static int MinPlace(string str)
        {
            char min = ' ';
            int minIndex = -1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].CompareTo(min) > 0)
                {
                    min = str[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }
        /// <summary>
        /// The function input a string and a char and return the amount of apearenses of the char in the string
        /// </summary>
        /// <param name="str">The string inputed</param>
        /// <param name="tav">The char inputed</param>
        /// <returns>The amount of times the char inputed apears in the string</returns>
        public static int CountChar(string str, char tav)
        {
            int cnt = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == tav)
                    cnt++;
            }
            return cnt;
        }
        /// <summary>
        /// The function inputs a string and checks if the string is in a rising order
        /// </summary>
        /// <param name="str">The string checking</param>
        /// <returns>True if the string is in a rising order,False if not</returns>
        public static bool IsSorted(string str)
        {
            char back = str[0];
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i].CompareTo(back) > 0)
                    return false;
                back = str[i];
            }
            return true;
        }



        static void Main(string[] args)
        {
            string str1 = "David";
            string str2 = "OriSe";
            LongestStr1(str1, str2);
            Console.WriteLine($"Longest string: "+LongestStr2(str1,str2));
            Console.Write("Reverse Str1: "); PrintReverseStr(str1);
            Console.Write("Reverse Str1: "); PrintReverseStr(str2);
            Console.WriteLine($"Reverse Str2: " + ReverseStr(str1));
            Console.WriteLine($"Reverse Str2: "+ReverseStr(str2));
            Console.Write("ZigZag1: "); PrintZigZag(str1);
            Console.Write("ZigZag2: "); PrintZigZag(str2);
            Console.WriteLine($"MinChar: " + MaxChar(str1));
            Console.WriteLine($"MaxChar: " + MaxChar(str2));
            Console.WriteLine($"MinPlace: "+MinPlace(str1));
            Console.WriteLine($"MinPlace: "+MinPlace(str2));
        }
    }
}
