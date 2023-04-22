using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassW_9_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double AmountMoney,shekels,pennies;
            Console.WriteLine("Enter an amount of money");
            AmountMoney = double.Parse(Console.ReadLine());
            shekels=Math.Floor(AmountMoney);
            pennies = Math.Round((AmountMoney - shekels)*100);
            Console.WriteLine("The amount of shekels is "+shekels);
            Console.WriteLine("The amount of pennies is "+(pennies));
        }
    }
}
