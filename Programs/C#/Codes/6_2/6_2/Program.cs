using System;

namespace _6_2
{
    class Program
    {
        static string ZigZag(string str1, string str2)
        {
            string print = "";
            for (int i = 0; i < Math.Max(str1.Length, str2.Length); i++)
            {
                if (i % 2 != 0)
                {
                    if (i < str1.Length)
                        print += str1[i];
                    else
                        print += str2[i];
                }
                else
                {
                    if (i < str2.Length)
                        print += str2[i];
                    else
                        print += str2[i];
                }
            }
            return print;
        }

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

        static string Intersection(string str1, string str2)
        {
            string newStr = "";
            for (int i = 0; i < str2.Length; i++)
            {
                if (str1.Contains($"{str2[i]}") == false)
                {
                    newStr += str1[i];
                }
            }
            return newStr;
        }

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

        static int ApearsAmount(string str,char ch)
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
        static string Uniqe(string str)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (ApearsAmount(str,str[i]) == 1)
                {
                    newStr += str[i];
                }
            }
            return newStr;
        }

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

        static int CountTriple(string str)
        {
            int cnt = 0;
            for (int i = 0; i < str.Length-2; i++)
            {
                if (str[i] == str[i]+2 && str[i+1] != str[i])
                {
                    cnt++;
                }
            }
            return cnt;
        }

        static string Ques8(string str, int k)
        {
            string newStr = str.Substring(0, k);
            for (int i = 1; i <= k; i++)
                newStr += str[k];
            newStr += str.Substring(k+1);
            return newStr;
        }
        static void Main(string[] args)
        {
            string str1 = "David";
            string str2 = "Maxim";
            string str3 = "Danial";
            Console.WriteLine($"ZigZag({str1},{str2}): "); Console.WriteLine(ZigZag(str1,str2));
            Console.WriteLine($"Union({str1},{str2}): "); Console.WriteLine(Union(str1,str2));
            Console.WriteLine($"Intersection({str1},{str2}): "); Console.WriteLine(Intersection(str1,str2));
            Console.WriteLine($"MaxSequence({str1},'D'): "); Console.WriteLine(MaxSequence(str1,'D'));
            Console.WriteLine($"Uniqe({str1}): "); Console.WriteLine(Uniqe(str1));
            Console.WriteLine($"DeleteChar({str3},'a'): "); Console.WriteLine(DeleteChar(str3,'a'));
            Console.WriteLine($"CountTriple({str1}): "); Console.WriteLine(CountTriple(str1));
            Console.WriteLine($"Ques8({str1},2): "); Console.WriteLine(Ques8(str1,2));
        }
    }
}
