using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q18
{
    class Program
    {
        //Entry claim: the function gets two variables as double, one is the dollar rate and the other is the precentage change
        //Exit claim: the function returns the new dollar after the change
        static double DollarChange (double dollar,double precentage)
        {
            double newDollar;
            newDollar = dollar + dollar * (precentage / 100);
            return newDollar;
        }
        static void Main(string[] args)
        {
            double dollar, precentage;
            Console.WriteLine("Enter the dollar rate");
            dollar = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the precenate it changed by");
            precentage = double.Parse(Console.ReadLine());
            Console.WriteLine($"The dollar today after the change is {DollarChange(dollar, precentage)}\n");
            //----------------------------
            Console.WriteLine("Enter the dollar rate");
            dollar = double.Parse(Console.ReadLine());
            double boughtDollat = dollar;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Enter the precenate it changed by in day {i}");
                precentage = double.Parse(Console.ReadLine());
                dollar = DollarChange(dollar, precentage);
            }
            Console.WriteLine($"When bought = {boughtDollat}, After ten days = {dollar},The difference {Math.Abs(boughtDollat-dollar)}");
        }
    }
}
