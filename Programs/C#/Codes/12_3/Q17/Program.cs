using System;

namespace Q17
{
    class Program
    {
        //Entry claim: the function gets a full number
        //Exit claim: the function return the length of the number
        static int LengthOfNum(int num)
        {
            int Num = Math.Abs(num);
            int cnt = 0;
            while (Num != 0)
            {
                cnt++;
                Num /= 10;
            }
            return cnt;
        }
        //Entry claim: The funtion gets a full positie number and a full positive digit
        //Exit claim: The function prints the position of digit in num
        //The function looks for the position of digit in the number
        static void WhereDigitIs(int num, int digit)
        {
            int count = LengthOfNum(num);
            while (num != 0)
            {
                if (num % 10 == digit)
                {
                    Console.WriteLine($"The digit {digit} is in position {count}");
                }
                count--;
                num /= 10;
            }
        }
        static void Main(string[] args)
        {
            int num, digit;
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Enter a digit you want to look for: ");
            digit = int.Parse(Console.ReadLine());
            WhereDigitIs(num, digit);
        }
    }
}
