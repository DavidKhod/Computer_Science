using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Program
    {
        static Random rnd = new Random();

        //Entry claim: The function inputs a pair of variables,and the amount of times the user wants to randomize numbers
        //Exit Claim: The function out puts a random number/numbers in between the numbers it got
        static string NumInBetween (int Num1,int Num2)
        {
            int NumBetween;
            string NumsBetween = "";
            Console.Write("Enter the amount You want to randomize: ");
            int Decision = int.Parse(Console.ReadLine());
                for (int i = 1; i <= Decision; i++)
                {
                    NumBetween = rnd.Next(Math.Min(Num1,Num2),Math.Max(Num1,Num2) + 1);
                    NumsBetween += $"|{NumBetween}| ";
                }
            return NumsBetween;
        }
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter a pair of numbers");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("--");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The random number in between {num1} and {num2} is {NumInBetween(num1,num2)}");
            Console.WriteLine("----------------------------");
            int Num1, Num2;
            Console.WriteLine("Enter a pair of number (to end write -999,-999)");
            Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("--");
            Num2 = int.Parse(Console.ReadLine());
            while (Num1 != -999 && Num2 != -999)
            {
                Console.WriteLine($"The five random numbers i between {num1} and {num2} are {NumInBetween(Num1,Num2)}");
                Console.WriteLine("Enter a pair of number (to end write -999,-999)");
                Num1 = int.Parse(Console.ReadLine());
                Num2 = int.Parse(Console.ReadLine());
            }
        }
    }
}
