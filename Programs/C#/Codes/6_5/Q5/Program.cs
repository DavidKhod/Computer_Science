using System;
namespace Q5
{
    class Program
    {
        static int FindLongestPolindrom(string str)
        {
            int placeOfCenter = str.IndexOf('*');
            bool endedRun = false;
            int max = 0;
            string maxWord = "";
            string word;
            for (int i = 0; !endedRun; i++)
            {
                if (placeOfCenter + i < str.Length && placeOfCenter- i >= 0)
                {
                    if (str[placeOfCenter - i] == str[placeOfCenter + i])
                    {
                        word = str.Substring(placeOfCenter - i, (i * 2) + 1);
                        if (word.Length > maxWord.Length)
                        {
                            max = word.Length;
                            maxWord = word;
                        }
                    }
                    else
                        endedRun = true;
                }
                else
                    endedRun = true;
            }
            if (max == 0)
                return 1;
            else
                return max;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a string with a center marked by '*': ");
            string input = "abcde*eda";
            Console.WriteLine($"Longest palindrome length: {FindLongestPolindrom(input)}");//5
        }
    }
}
