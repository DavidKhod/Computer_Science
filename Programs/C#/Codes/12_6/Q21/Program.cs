using System;

namespace Q21
{
    class Program
    {
        //Entry claim: the function gets a random positive full number
        //Exit claim: the function return the biggest digit within the number
        static int MaxNum(int num)
        {
            int max = 0;
            while (num != 0)
            {
                if (num % 10 > max)
                {
                    max = num % 10;
                }
                num /= 10;
            }
            return max;
        }
        //Entry claim: the function gets a random positive full number
        //Exit claim: the function return the smallest digit within the number
        static int MinNum(int num)
        {
            int min = 10;
            while (num != 0)
            {
                if (num % 10 < min)
                {
                    min = num % 10;
                }
                num /= 10;
            }
            return min;
        }
        //Entry claim: the function gets a full positive number
        //Exit claim: the function outputs the number with the last digit of the sum of the biggest digit of the input and the smallest(twice) on the right
        static int RenewID(int id)
        {
            int max, min;
            int tempid = id;
            max = MaxNum(tempid);
            min = MinNum(tempid);
            tempid = tempid * 10;
            tempid += ((min + max) % 10);
            max = MaxNum(tempid);
            min = MinNum(tempid);
            tempid *= 10;
            tempid += ((min + max) % 10);
            return tempid;
        }
        static void Main(string[] args)
        {
            int id;
            Console.WriteLine("Enter your id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine($"The new id is {RenewID(id)}");
        }
    }
}
