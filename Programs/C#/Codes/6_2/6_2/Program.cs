using System;

namespace _6_2
{
    class Program
    {
        /// <summary>
        /// The function inputs two strings and return the first index of the the second of the second and so on
        /// </summary>
        /// <param name="str1">The first string inputed</param>
        /// <param name="str2">The second string inputed</param>
        /// <returns>a new string of the first index of the the second of the second and so on</returns>
        static string ZigZag(string str1, string str2)
        {
            string print = "";
            for (int i = 0; i < Math.Max(str1.Length, str2.Length); i++)
            {
                if (i % 2 != 0)
                {
                    if (i <= str1.Length-1)
                        print += str1[i];
                    else
                        print += str2[i];
                }
                else
                {
                    if (i <= str2.Length-1)
                        print += str2[i];
                    else
                        print += str2[i];
                }
            }
            return print;
        }
        /// <summary>
        /// The function inputes two string and return a new string of letters that appear in both strings
        /// </summary>
        /// <param name="str1">The first string inputed</param>
        /// <param name="str2">The second string inputed</param>
        /// <returns>a new string of letters that appear in both strings</returns>
        static string Union(string str1, string str2)
        {
            string newStr = "";
            for (int i = 0; i < str2.Length; i++)
            {
                if (str1.Contains($"{str2[i]}"))
                {
                    newStr += str2[i];
                }
            }
            return newStr;
        }
        /// <summary>
        /// The function inputs two strings and returns a new string of letters that only appear in the first string inputed
        /// </summary>
        /// <param name="str1">The first string inputed</param>
        /// <param name="str2">The first string inputed</param>
        /// <returns>a new string of letters that only appear in the first string inputed</returns>
        static string Intersection(string str1, string str2)
        {
            string newStr = "";
            for (int i = 0; i < str2.Length; i++)
            {
                if (str1.Contains($"{str2[i]}") == false)
                {
                    newStr += str2[i];
                }
            }
            return newStr;
        }
        /// <summary>
        /// The function inputs a string and a char and returns the biggest amount of appearences of the char within the string in a row
        /// </summary>
        /// <param name="str">The looking through</param>
        /// <param name="ch">The char looking for</param>
        /// <returns>the biggest amount of appearences of the char within the string in a row</returns>
        static int MaxSequence(string str, char ch)
        {
            if (str.Contains($"{ch}") == false)
                return -1;
            bool found = false;
            bool ended = false;
            int cnt = 0;
            for (int i = 0; i < str.Length && (!found && !ended || found && !ended); i++)
            {
                if (str[i] == ch && !found)
                    found = true;
                if (str[i] != ch && found)
                    ended = true;
                if (str[i] == ch && found)
                    cnt++;
            }
            return cnt;
        }
        /// <summary>
        /// The function inputs a string and a char and returns the amount of appearences of the char within the string
        /// </summary>
        /// <param name="str">The string going through</param>
        /// <param name="ch">The char looking for</param>
        /// <returns>the amount of appearences of the char within the string</returns>
        static int ApearsAmount(string str, char ch)
        {
            int cnt = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    cnt++;
                }
            }
            return cnt;
        }
        /// <summary>
        /// The function inputs a string and return a new string of the letters that appear within the string only once
        /// </summary>
        /// <param name="str">The string going through</param>
        /// <returns> a new string of the letters that appear within the string only once</returns>
        static string Uniqe(string str)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (ApearsAmount(str, str[i]) == 1)
                {
                    newStr += str[i];
                }
            }
            return newStr;
        }
        /// <summary>
        /// The function inputs a string and a char and return a new string but without ant appearances for the char within the string
        /// </summary>
        /// <param name="str">The string going through</param>
        /// <param name="ch">The char deleting within the string inputed</param>
        /// <returns>a new string but without ant appearances for the char within the string</returns>
        static string DeleteChar(string str, char ch)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ch)
                {
                    newStr += str[i];
                }
            }
            return newStr;
        }
        /// <summary>
        /// The function inputs a string and return the amount of triplets(three letters that the first is equal to the third and the second is not equal to the first and second) in the string
        /// </summary>
        /// <param name="str">The string going through</param>
        /// <returns>The amount of triplets(three letters that the first is equal to the third and the second is not equal to the first and second) in the string</returns>
        static int CountTriple(string str)
        {
            int cnt = 0;
            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str[i] == str[i] + 2 && str[i + 1] != str[i])
                {
                    cnt++;
                }
            }
            return cnt;
        }
        /// <summary>
        /// The fucntion inputs a string and an int that represents an index
        /// </summary>
        /// <param name="str">The string inputed</param>
        /// <param name="k">The int inputed that represents an index</param>
        /// <returns>A new string that is build of all the letters until k, k amount of letters in the place if k, and the rest of the string after k</returns>
        static string Ques8(string str, int k)
        {
            string newStr = str.Substring(0, k);
            for (int i = 1; i <= k; i++)
                newStr += str[k];
            newStr += str.Substring(k + 1);
            return newStr;
        }
        static void Main(string[] args)
        {
            string str1 = "David";
            string str2 = "Maxim";
            string str3 = "Danial";
            Console.Write($"ZigZag({str1},{str2}): "); Console.WriteLine(ZigZag(str1, str2));
            Console.Write($"Union({str1},{str2}): "); Console.WriteLine(Union(str1, str2));
            Console.Write($"Intersection({str1},{str2}): "); Console.WriteLine(Intersection(str1, str2));
            Console.Write($"MaxSequence({str1},'D'): "); Console.WriteLine(MaxSequence(str1, 'D'));
            Console.Write($"Uniqe({str1}): "); Console.WriteLine(Uniqe(str1));
            Console.Write($"DeleteChar({str3},'a'): "); Console.WriteLine(DeleteChar(str3, 'a'));
            Console.Write($"CountTriple({str1}): "); Console.WriteLine(CountTriple(str1));
            Console.Write($"Ques8({str1},2): "); Console.WriteLine(Ques8(str1, 2));
        }
    }
}
