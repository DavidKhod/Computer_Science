using System;

namespace VoidRecurcion
{
    class Program
    {
        //Functions that don't return a value, most of the are printing someting

        //Entry claim: The function inputs an integer
        //Exit claim: The function prints in the following order:
        //first the number, then the number without the last digit and so on
        static void NumPrefix(int num)
        {
            if (num / 10 == 0)//one digit number
                Console.WriteLine(num);
            else
            {
                Console.WriteLine(num);
                NumPrefix(num / 10);//Recursive call after removing the last digit
            }
        }

        static void NumPrefix2(int num)
        {
            if(num != 0)
            {
                Console.WriteLine(num);
                NumPrefix2(num / 10);
            }
        }

        //Entry claim: The function input an integer
        //Exit claim: The function print from 1 - n(the integer inputed)
        static void PrintUp(int n)
        {
            if(n != 0)
            {
                PrintUp(n - 1);
                Console.Write($"{n} ");
            }
        }
        static void Main(string[] args)
        {
            //NumPrefix(13512);
            //NumPrefix2(13512);
            PrintUp(5);
        }
    }
}
