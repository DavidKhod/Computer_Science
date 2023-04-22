using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9_10_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade,Rounded,Left;
            Console.WriteLine("Enter a grade from 4-10");
            grade = double.Parse(Console.ReadLine());
            Rounded = Math.Round(grade);
            Left = Math.Round((Rounded - grade)*100)/100;
            Console.WriteLine("The rounded grade is "+Rounded);
            Console.WriteLine("The leftover for the year grade is "+Left);
        }
    }
}
