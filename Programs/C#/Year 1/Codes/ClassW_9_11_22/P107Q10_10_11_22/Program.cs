using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P107Q10_10_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double Num, AfterDot,NewNum;
            Console.WriteLine("Enter a number with three number after the dot");
            Num = double.Parse(Console.ReadLine());
            AfterDot = (Math.Round(((Num - Math.Floor(Num)) * 100)) / 100 + 0.01);
            NewNum = Math.Floor(Num) + AfterDot;
            
            Console.WriteLine("The rounded number with rounded after dot number is "+NewNum);

        }
    }
}
