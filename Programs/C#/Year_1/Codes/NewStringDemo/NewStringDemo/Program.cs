using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using stringMethodsDemo;

namespace stringClassMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int demo;

            Console.WriteLine("\n\n\n ------------------------------------------------------------------");
            Console.WriteLine("\n        Demonstration of string class methods        ");
            Console.WriteLine("\n                 Created by Udi Omer         ");
            Console.WriteLine("\n ------------------------------------------------------------------ ");

            Console.WriteLine("Enter a method number (1-9) (to end, enter 0):");
            Console.WriteLine("#1:  str.Length");
            Console.WriteLine("#2:  str[i]");
            Console.WriteLine("#3:  str.Equals(string st2)");
            Console.WriteLine("#4:  str.CompareTo(string st2)");
            Console.WriteLine("#5:  str.Contains(char ch / string st)");
            Console.WriteLine("#6:  str.IndexOf(char ch / string st)");
            Console.WriteLine("#7:  str.IndexOf(char ch / string st, int from)");
            Console.WriteLine("#8:  str.Substring(int from)");
            Console.WriteLine("#9:  str.Substring(int from, int length)");
            Console.WriteLine("#0: Exit");
            Console.Write("\nEnter demo number:");

            demo = int.Parse(Console.ReadLine());

            while (demo != 0)
            {

                switch (demo)
                {
                    case 1: stringMethods.Demo_Length(); // הדגמת הפעולה length
                        break;
                    case 2: stringMethods.Demo_Char_at_index_i(); // הדגמת הפעולה charAt
                        break;
                    case 3: stringMethods.Demo_Equals();  // הדגמת הפונקצה equals
                        break;
                    case 4: stringMethods.Demo_CompareTo();  // הדגמת הפעולה compareTo
                        break;
                    case 5: stringMethods.Demo_Contains(); // הדגמת הפעולה Contains
                        break;
                    case 6: stringMethods.Demo_IndexOf();  // הדגמת הפעולה indexOf
                        break;
                    case 7: stringMethods.Demo_IndexOfFrom();  // הדגמת הפעולה indexOf
                        break;
                    case 8: stringMethods.Demo_Substring();   // הדגמת הפונקציה substring
                        break;
                    case 9: stringMethods.Demo_SubstringFromCount();   // הדגמת הפונקציה substring
                        break;

                    default:
                        Console.WriteLine("wrong demo number (enter demo number 1-19 or 0 to exit).");
                        break;
                }

                Console.Clear();
                Console.WriteLine("\n\n\n ------------------------------------------------------------------");
                Console.WriteLine("\n        Demonstration of string class methods        ");
                Console.WriteLine("\n                 Created by Udi Omer         ");
                Console.WriteLine("\n ------------------------------------------------------------------ ");

                Console.WriteLine("Enter a method number (1-20) (to end, enter 0):");
                Console.WriteLine("#1:  str.Length");
                Console.WriteLine("#2:  str[i]");
                Console.WriteLine("#3:  str.Equals(string st2)");
                Console.WriteLine("#4:  str.CompareTo(string st2)");
                Console.WriteLine("#5:  str.Contains(char ch / string st)");
                Console.WriteLine("#6:  str.IndexOf(char ch / string st)");
                Console.WriteLine("#7:  str.IndexOf(char ch / string st, int from)");
                Console.WriteLine("#8:  str.Substring(int from)");
                Console.WriteLine("#9:  str.Substring(int from, int length)");
                Console.WriteLine("#0: Exit");
                Console.Write("\nEnter demo number:");

                demo = int.Parse(Console.ReadLine());
            }
            while (demo != 0) ;
        }
    }
}
